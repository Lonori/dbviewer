using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormMain : Form
    {
        private Mysqli DB;
        private Panel[] panels1;
        private Panel[] panels2;
        private Table1 ct_list;
        private Table2 ct_create;

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
            this.Text = host + " | DB Viewer";
            Log(DB.HostInfo + " - Подключение успешно");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDBTree();
            panels1 = new Panel[] { panel_db_create, panel_database };
            panels2 = new Panel[] { panel_table_create, panel_table_list, panel_table_data };
            ct_create = new Table2(table_creator, new string[] { "Имя", "Тип", "Размер", "Индекс", "Подпись" });
            ct_create.RowHeight = 40;
            ct_list = new Table1(table_tables, new string[] { "Таблица", "Сравнение", "Тип", "Строки", "Действия" });
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                DB.SelectDB(e.Node.Text);
                using (DbDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + e.Node.Text + "'"))
                {
                    change_panel1("panel_database");
                    change_panel2("panel_table_list");
                    e.Node.Nodes.Clear();
                    while (reader.Read())
                    {
                        string table_name = reader.GetString(0);
                        e.Node.Nodes.Add(table_name);
                        ct_list.AddRow(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
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
                    change_panel1("panel_database");
                    change_panel2("panel_table_data");
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
            change_panel1("panel_db_create");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            change_panel2("panel_table_list");
            using (DbDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + treeView1.SelectedNode.Text + "'"))
            {
                while (reader.Read())
                {
                    string table_name = reader.GetString(0);
                    ct_list.AddRow(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            change_panel2("panel_table_create");
        }

        private void button_add_column_Click(object sender, EventArgs e)
        {
            ct_create.AddRow();
        }

        private void button_table_create_Click(object sender, EventArgs e)
        {
            if (textbox_table_name.TextLength == 0)
            {
                ShowError("Название таблицы не может быть пустым");
                return;
            }
            int amount = 0;
            for (int i = 0; i < ct_create.Length; i++) if (ct_create[i][0].Text.Length > 0) amount++;
            if (amount <= 0)
            {
                ShowError("Таблица не содержит ни одного поля");
                return;
            }
            string sql = "CREATE TABLE";
            sql += " `" + textbox_table_name.Text + "` (";
            for (int i = 0; i < ct_create.Length; i++)
            {
                if (ct_create[i][0].Text.Length <= 0) continue;
                ComboBox comboBox1 = (ComboBox)ct_create[i][1];
                string str1 = (string)comboBox1.SelectedItem;
                sql += "`" + ct_create[i][0].Text + "` " + str1;
                if (ct_create[i][2].Text.Length > 0)
                {
                    sql += "(" + ct_create[i][2].Text + ")";
                }
                sql += " NOT NULL";
                if (ct_create[i][4].Text.Length > 0)
                {
                    sql += " COMMENT '" + ct_create[i][4].Text + "'";
                }
                sql += ",";
            }
            sql = sql.Remove(sql.Length - 1);
            List<string> ind_primary = new List<string>();
            List<string> ind_index = new List<string>();
            for (int i = 0; i < ct_create.Length; i++)
            {
                ComboBox comboBox2 = (ComboBox)ct_create[i][3];
                string str2 = (string)comboBox2.SelectedItem;
                switch (str2)
                {
                    case "PRIMARY":
                        ind_primary.Add(ct_create[i][0].Text);
                        break;
                    case "INDEX":
                        ind_index.Add(ct_create[i][0].Text);
                        break;
                }
            }
            if (ind_primary.Count > 0) sql += ", PRIMARY KEY (" + ListSqlStringJoin(ind_primary) + ")";
            if (ind_index.Count > 0) sql += ", INDEX (" + ListSqlStringJoin(ind_primary) + ")";
            sql += ") ENGINE = InnoDB";
            if (DB.Write(sql))
            {
                change_panel2("panel_table_list");
                Log(sql);
            }
            else
            {
                Log(DB.Error);
            }
        }
    }
}
