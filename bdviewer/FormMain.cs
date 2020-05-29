using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace bdviewer
{
    public partial class FormMain : Form
    {
        private Mysqli DB;
        private Panel[] panels1;
        private Panel[] panels2;

        public FormMain()
        {
            FormConnect form = new FormConnect();
            bool connected = false;
            string host;
            do
            {
                form.ShowDialog();
                if (form.ClickedButton)
                {
                    form.ClickedButton = false;
                }
                else
                {
                    Dispose();
                    return;
                }

                host = form.Hostname;
                string username = form.Username;
                string password = form.Password;

                DB = new Mysqli(host, username, password);
                if (DB.ConnectError == "")
                {
                    connected = true;
                }
                else
                {
                    form.Status = DB.ConnectError;
                }
            } while (connected != true);
            form.Dispose();

            InitializeComponent();
            panels1 = new Panel[] { panel_crdb, panel_tables, panel_table };
            panels2 = new Panel[] { panel_table_create, panel_table_list };
            this.Text = host + " | DB Viewer";
            Log(DB.HostInfo + " - Подключение успешно");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDBTree();
            }
            catch (Exception error)
            {
                ShowError(error.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                using (DbDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + e.Node.Text + "'"))
                {
                    change_panel1("panel_tables");
                    change_panel2("panel_table_list");
                    e.Node.Nodes.Clear();
                    while (reader.Read())
                    {
                        string table_name = reader.GetString(0);
                        e.Node.Nodes.Add(table_name);
                        add_layout1(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
                    }
                    e.Node.Expand();
                }

                Log("True");
            }
            else
            {
                DB.SelectDB(e.Node.Parent.Text);
                using (DbDataReader reader = DB.Read("SELECT * FROM `" + e.Node.Text + "` WHERE 1 LIMIT 25"))
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = reader.GetName(i);
                        column.ValueType = reader.GetFieldType(i);
                        dataGridView1.Columns.Add(column);
                    }
                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.IsDBNull(i))
                            {
                                row[i] = "NULL";
                            }
                            else
                            {
                                row[i] = reader.GetString(i);
                            }
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }

                Log("False");
            }
        }

        private void UpdateDBTree()
        {
            using (DbDataReader reader = DB.Read("SHOW DATABASES"))
            {
                treeView1.Nodes.Clear();
                while (reader.Read())
                {
                    string db_name = reader.GetString(0);
                    if (db_name == "information_schema") continue;
                    treeView1.Nodes.Add(db_name);
                }
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }

        private void Log(string message)
        {
            DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss K");
            log_label.Text += "[" + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + "] " + message + "\r\n";
            log_panel.AutoScrollPosition = new Point(0, log_label.Height);
        }

        private void create_database_Click(object sender, EventArgs e)
        {
            if (name_new_db.TextLength == 0)
            {
                ShowError("Имя базы данных не может быть пустым");
                return;
            }
            if (DB.Write("CREATE DATABASE `" + name_new_db.Text + "` charset=utf8mb4"))
            {
                Log("База данных '" + name_new_db.Text + "' успешно создана");
                name_new_db.Text = "";
                UpdateDBTree();
            }
            else
            {
                Log(DB.Error);
            }
        }

        private void create_bd_Click(object sender, EventArgs e)
        {
            change_panel1("panel_crdb");
        }

        private void change_panel1(string name)
        {
            for (int i = 0; i < panels1.Length; i++)
            {
                if (name == panels1[i].Name)
                {
                    panels1[i].Visible = true;
                }
                else
                {
                    panels1[i].Visible = false;
                }
            }
        }

        private void change_panel2(string name)
        {
            clear_layout1();
            clear_layout2();

            for (int i = 0; i < panels2.Length; i++)
            {
                if (name == panels2[i].Name)
                {
                    panels2[i].Visible = true;
                    if (name == "panel_table_create") add_layout2();
                }
                else
                {
                    panels2[i].Visible = false;
                }
            }
        }

        private void add_layout1(string table_name, string table_collation, string engine, string table_rows)
        {
            table_tables.RowCount += 1;
            table_tables.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_tables.Height += 30;

            table_tables.Controls.Add(new LinkLabel() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, BackColor = SystemColors.Control, Margin = new Padding(0), Text = table_name }, 0, table_tables.RowCount - 1);
            table_tables.Controls.Add(new Label() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, BackColor = SystemColors.GradientInactiveCaption, Margin = new Padding(0), Text = table_collation }, 1, table_tables.RowCount - 1);
            table_tables.Controls.Add(new Label() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, BackColor = SystemColors.Control, Margin = new Padding(0), Text = engine }, 2, table_tables.RowCount - 1);
            table_tables.Controls.Add(new Label() { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleRight, BackColor = SystemColors.GradientInactiveCaption, Margin = new Padding(0), Text = table_rows }, 3, table_tables.RowCount - 1);
        }

        private void clear_layout1()
        {
            table_tables.RowStyles.Clear();
            table_tables.Controls.Clear();
            table_tables.Height = 30;
            table_tables.RowCount = 1;
            table_tables.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_tables.Controls.Add(create_column_name("Таблица"), 0, 0);
            table_tables.Controls.Add(create_column_name("Сравнение"), 1, 0);
            table_tables.Controls.Add(create_column_name("Тип"), 1, 0);
            table_tables.Controls.Add(create_column_name("Строки"), 1, 0);
            table_tables.Controls.Add(create_column_name("Действия"), 1, 0);
        }

        private void add_layout2()
        {
            table_creator.RowCount += 1;
            table_creator.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            table_creator.Height += 40;

            table_creator.Controls.Add(create_textbox_table(), 0, table_creator.RowCount - 1);
            table_creator.Controls.Add(create_combobox_table(new object[] { "INT", "FLOAT", "VARCHAR", "TEXT", "DATE" }, "INT"), 1, table_creator.RowCount - 1);
            table_creator.Controls.Add(create_textbox_table(), 2, table_creator.RowCount - 1);
            table_creator.Controls.Add(create_combobox_table(new object[] { "---", "PRIMARY", "INDEX" }, "---"), 3, table_creator.RowCount - 1);
            table_creator.Controls.Add(create_textbox_table(), 4, table_creator.RowCount - 1);
        }

        private void clear_layout2()
        {
            table_creator.RowStyles.Clear();
            table_creator.Controls.Clear();
            table_creator.Height = 30;
            table_creator.RowCount = 1;
            table_creator.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table_creator.Controls.Add(create_column_name("Имя"), 0, 0);
            table_creator.Controls.Add(create_column_name("Тип"), 1, 0);
            table_creator.Controls.Add(create_column_name("Размер"), 1, 0);
            table_creator.Controls.Add(create_column_name("Индекс"), 1, 0);
            table_creator.Controls.Add(create_column_name("Подпись"), 1, 0);
        }

        private Label create_column_name(string name)
        {
            return new Label()
            {
                AutoSize = true,
                BackColor = SystemColors.ActiveCaption,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                TabIndex = 0,
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private ComboBox create_combobox_table(object[] collection, string text)
        {
            ComboBox elem = new ComboBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                FormattingEnabled = true,
                Margin = new Padding(4, 0, 4, 0),
                Text = text
            };
            elem.Items.AddRange(collection);
            return elem;
        }

        private TextBox create_textbox_table()
        {
            return new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(4, 0, 4, 0)
            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            change_panel2("panel_table_list");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            change_panel2("panel_table_create");
        }

        private void button_add_column_Click(object sender, EventArgs e)
        {
            add_layout2();
        }
    }
}
