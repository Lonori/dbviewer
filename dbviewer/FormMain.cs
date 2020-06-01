using bdviewer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormMain : Form
    {
        private Mysqli DB;
        private PanelTriger pt_db_func;
        private PanelTriger pt_table_func;
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
            this.Text = host + ":3306 | DB Viewer";
            Log(DB.HostInfo + " - Подключение успешно");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDBTree();
            pt_db_func = new PanelTriger(new Panel[] { panel_db_create, panel_database });
            pt_table_func = new PanelTriger(new Panel[] { panel_table_create, panel_table_list, panel_table_data, panel_sql });
            ct_list = new Table1(table_tables, new string[] { "Таблица", "Сравнение", "Тип", "Строки", "Действия" });
            ct_create = new Table2(table_creator, new string[] { "Имя", "Тип", "Размер", "Индекс", "Подпись" });
            ct_create.RowHeight = 40;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                DB.SelectDB(e.Node.Text);
                using (DbDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + e.Node.Text + "'"))
                {
                    pt_db_func.ChangeActivePanel(panel_database);
                    pt_table_changer(panel_table_list);
                    e.Node.Nodes.Clear();
                    while (reader.Read())
                    {
                        string table_name = reader.GetString(0);
                        e.Node.Nodes.Add(new TreeNode(table_name) { ImageIndex = 1 });
                        ct_list.AddRow(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
                    }
                    e.Node.Expand();
                }

                Log("tree db");
            }
            else
            {
                //table_query_result.Rows.Clear();
                //table_query_result.Columns.Clear();
                data_cache.Tables.Clear();
                pt_db_func.ChangeActivePanel(panel_database);
                pt_table_changer(panel_table_data);

                DB.SelectDB(e.Node.Parent.Text);
                adapter = new MySqlDataAdapter("SELECT * FROM `" + e.Node.Text + "` WHERE 1", DB.conn);
                adapter.Fill(data_cache);
                table_query_result.DataSource = data_cache.Tables[0];

                using (DbDataReader reader = DB.Read("SELECT `COLUMN_NAME`,`COLUMN_COMMENT` FROM `information_schema`.`COLUMNS` WHERE `TABLE_SCHEMA`='" + e.Node.Parent.Text + "' AND `TABLE_NAME`='" + e.Node.Text + "'"))
                {
                    while (reader.Read())
                    {
                        string column_name = reader.GetString(0);
                        string column_comment = reader.GetString(1);
                        if (column_comment == "") continue;
                        for (int i = 0; i < table_query_result.Columns.Count; i++)
                        {
                            if (table_query_result.Columns[i].Name == column_name)
                            {
                                table_query_result.Columns[i].HeaderText = column_comment;
                                break;
                            }
                        }
                    }
                }

                Log("tree table");
            }
        }

        private MySqlDataAdapter adapter;

        private void test_update()
        {
            try
            {
                if(!data_cache.HasChanges()) return;
                table_query_result.EndEdit();
                table_query_result.CurrentCell = null;
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Update(data_cache);

                data_cache.Clear();
                adapter.Fill(data_cache);
                Log("Изменения успешно сохранены");
            }
            catch
            {
                Log("Ошибка сохранения");
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
            pt_db_func.ChangeActivePanel(panel_db_create);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pt_table_changer(panel_table_list);
            using (DbDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + db_tree_list.SelectedNode.Text + "'"))
            {
                while (reader.Read())
                {
                    string table_name = reader.GetString(0);
                    ct_list.AddRow(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
                }
            }
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
            /*List<string> ind_index = new List<string>();*/
            for (int i = 0; i < ct_create.Length; i++)
            {
                ComboBox comboBox2 = (ComboBox)ct_create[i][3];
                string str2 = (string)comboBox2.SelectedItem;
                switch (str2)
                {
                    case "PRIMARY":
                        ind_primary.Add(ct_create[i][0].Text);
                        break;
                        /*case "INDEX":
                            ind_index.Add(ct_create[i][0].Text);
                            break;*/
                }
            }
            if (ind_primary.Count > 0) sql += ", PRIMARY KEY (" + ListSqlStringJoin(ind_primary) + ")";
            /*if (ind_index.Count > 0) sql += ", INDEX (" + ListSqlStringJoin(ind_primary) + ")";*/
            sql += ") ENGINE = InnoDB";
            if (DB.Write(sql))
            {
                pt_table_changer(panel_table_list);
                Log(sql);
            }
            else
            {
                Log(DB.Error);
            }
        }

        private void plaseholder_listener_Enter(object sender, EventArgs e)
        {
            TextBox elem = (TextBox)sender;
            if (elem.Text == (string)elem.Tag && elem.ForeColor == Color.Silver)
            {
                elem.Text = "";
                elem.ForeColor = SystemColors.WindowText;
            }
        }

        private void plaseholder_listener_Leave(object sender, EventArgs e)
        {
            TextBox elem = (TextBox)sender;
            if (elem.Text == "")
            {
                elem.Text = (string)elem.Tag;
                elem.ForeColor = Color.Silver;
            }
        }

        private void tool_panel_tsb_Click(object sender, EventArgs e)
        {
            ToolStripButton elem = (ToolStripButton)sender;
            if (elem.Name == "tool_panel_tsb4") pt_table_changer(panel_sql);
            if (db_tree_list.SelectedNode.Parent == null)
            {
                if (elem.Name == "tool_panel_tsb2") pt_table_changer(panel_table_list);
                if (elem.Name == "tool_panel_tsb3") pt_table_changer(panel_table_create);
                //if (elem.Name == "tool_panel_tsb6") pt_table_changer();
                //if (elem.Name == "tool_panel_tsb7") pt_table_changer();
                //if (elem.Name == "tool_panel_tsb9") test_update();
            }
            else
            {
                if (elem.Name == "tool_panel_tsb1") pt_table_changer(panel_table_data);
                //if (elem.Name == "tool_panel_tsb5") pt_table_changer();
                if (elem.Name == "tool_panel_tsb8") test_update();
            }
        }

        private void table_query_result_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Log("UserAddedRow: " + sender.GetType().ToString());
        }

        private void table_query_result_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Log("UserDeletedRow: " + sender.GetType().ToString());
        }

        private void table_query_result_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context.HasFlag(DataGridViewDataErrorContexts.LeaveControl))
            {
                table_query_result.CancelEdit();
            }
            else
            {
                Log(e.Exception.Message);
            }
        }
    }
}
