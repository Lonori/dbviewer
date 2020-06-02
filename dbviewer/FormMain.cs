using bdviewer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormMain : Form
    {
        private DBtool DB;
        private PanelTriger pt_db_func;
        private PanelTriger pt_table_func;
        private Table1 ct_list;
        private Table2 ct_create;
        private InfoShow info;

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

                DB = new DBtool(host, username, password);
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
            Text = host + ":3306 | DB Viewer";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveDB())
            {
                e.Cancel = true;
                return;
            }
            DB.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info = new InfoShow(log_box);
            pt_db_func = new PanelTriger(new Panel[] { panel_db_create, panel_database });
            pt_table_func = new PanelTriger(new Panel[] { panel_table_create, panel_table_list, panel_table_data, panel_sql });
            ct_list = new Table1(table_tables, new string[] { "Таблица", "Сравнение", "Тип", "Строки", "Действия" });
            ct_create = new Table2(table_creator, new string[] { "Имя", "Тип", "Размер", "Индекс", "Подпись" });

            info.Log(DB.HostInfo + " - Подключение успешно");
            DB.DataGridInclude(table_query_result);
            UpdateDBTree();

            ct_create.RowHeight = 40;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                DB.SelectDB(e.Node.Text);
                pt_db_func.ChangeActivePanel(panel_database);
                pt_table_changer(panel_table_list);
                UpdateTableTree(e.Node);
            }
            else
            {
                pt_db_func.ChangeActivePanel(panel_database);
                pt_table_changer(panel_table_data);

                DB.SelectDB(e.Node.Parent.Text);
                DB.ReadInCache("SELECT * FROM `" + e.Node.Text + "`", e.Node.Text);
                info.Log("SELECT * FROM `" + e.Node.Text + "`");
            }
        }

        private void create_database_Click(object sender, EventArgs e)
        {
            if (name_new_db.TextLength == 0)
            {
                InfoShow.Warning("Имя базы данных не может быть пустым");
                return;
            }
            if (DB.Write("CREATE DATABASE `" + name_new_db.Text + "` charset=utf8mb4"))
            {
                info.Log("CREATE DATABASE `" + name_new_db.Text + "` charset=utf8mb4");
                info.Log("База данных '" + name_new_db.Text + "' успешно создана");
                name_new_db.Clear();
                UpdateDBTree();
            }
            else
            {
                InfoShow.Error("Ошибка создания базы данных");
                info.Log(DB.Error);
            }
        }

        private void create_bd_Click(object sender, EventArgs e)
        {
            pt_db_func.ChangeActivePanel(panel_db_create);
        }

        private void button_add_column_Click(object sender, EventArgs e)
        {
            ct_create.AddRow();
        }

        private void button_table_create_Click(object sender, EventArgs e)
        {
            if (textbox_table_name.TextLength == 0)
            {
                InfoShow.Warning("Название таблицы не может быть пустым");
                return;
            }
            int amount = 0;
            for (int i = 0; i < ct_create.Length; i++) if (ct_create[i][0].Text.Length > 0) amount++;
            if (amount <= 0)
            {
                InfoShow.Warning("Таблица не содержит ни одного поля");
                return;
            }
            List<string> ind_primary = new List<string>();
            string sql = "CREATE TABLE";
            sql += " `" + textbox_table_name.Text + "` (";
            for (int i = 0; i < ct_create.Length; i++)
            {
                if (ct_create[i][0].Text.Length <= 0) continue;
                sql += "`" + ct_create[i][0].Text + "` " + ((ComboBox)ct_create[i][1]).SelectedItem.ToString();
                if (ct_create[i][2].Text.Length > 0)
                {
                    try
                    {
                        sql += "(" + int.Parse(ct_create[i][2].Text) + ")";
                    }
                    catch
                    {
                        InfoShow.Warning("Неверно указан размер поля");
                        return;
                    }
                }
                sql += " NOT NULL";
                switch (((ComboBox)ct_create[i][3]).SelectedItem.ToString())
                {
                    case "PRIMARY": ind_primary.Add(ct_create[i][0].Text); break;
                }
                if (ct_create[i][4].Text.Length > 0)
                {
                    sql += " COMMENT '" + ct_create[i][4].Text + "'";
                }
                sql += ",";
            }
            sql = sql.Remove(sql.Length - 1);
            if (ind_primary.Count > 0) sql += ", PRIMARY KEY (`" + string.Join("`,`", ind_primary) + "`)";
            sql += ") ENGINE = InnoDB";
            if (DB.Write(sql))
            {
                pt_table_changer(panel_table_list);
                UpdateTableTree(db_tree_list.SelectedNode);
                info.Log(sql);
            }
            else
            {
                InfoShow.Error("Ошибка создания таблицы");
                info.Log(DB.Error);
            }
        }

        private void table_query_result_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context.HasFlag(DataGridViewDataErrorContexts.LeaveControl))
            {
                table_query_result.CancelEdit();
            }
            else
            {
                InfoShow.Error(e.Exception.Message);
            }
        }

        private void tool_panel_tsb_Click(object sender, EventArgs e)
        {
            ToolStripButton elem = (ToolStripButton)sender;
            if (elem.Name == "tool_panel_tsb5") pt_table_changer(panel_sql);
            if (db_tree_list.SelectedNode.Parent == null)
            {
                if (elem.Name == "tool_panel_tsb3")
                {
                    pt_table_changer(panel_table_list);
                    UpdateTableTree(db_tree_list.SelectedNode);
                }
                if (elem.Name == "tool_panel_tsb4")
                {
                    pt_table_changer(panel_table_create);
                    ct_create.AddRow();
                }
                //if (elem.Name == "tool_panel_tsb7") pt_table_changer();
                //if (elem.Name == "tool_panel_tsb8") pt_table_changer();
                if (elem.Name == "tool_panel_tsb10")
                {
                    if (!InfoShow.Confirm("Вы действительно хотите удалить данную базу данных?")) return;
                    if (DB.Write("DROP DATABASE `" + db_tree_list.SelectedNode.Text + "`"))
                    {
                        info.Log("DROP DATABASE `" + db_tree_list.SelectedNode.Text + "`");
                    }else
                    {
                        InfoShow.Error("Ошибка удаления базы данных");
                        info.Log(DB.Error);
                        return;
                    }
                }
            }
            else
            {
                if (elem.Name == "tool_panel_tsb1")
                {
                    table_query_result.EndEdit();
                    table_query_result.CurrentCell = null;
                    if (!DB.HasChanges()) return;
                    if (DB.SaveChange())
                    {
                        info.Log("Изменения успешно сохранены");
                    }
                    else
                    {
                        InfoShow.Error("Ошибка сохранения");
                        info.Log(DB.Error);
                    }
                }
                if (elem.Name == "tool_panel_tsb2")
                {
                    pt_table_changer(panel_table_data);
                    DB.ReadInCache("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`", db_tree_list.SelectedNode.Text);
                    info.Log("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`");
                }
                if (elem.Name == "tool_panel_tsb9")
                {
                    if (!InfoShow.Confirm("Вы действительно хотите удалить данную таблицу?")) return;
                    if (!DB.Write("DROP TABLE `" + db_tree_list.SelectedNode.Text + "`"))
                    {
                        UpdateTableTree(db_tree_list.SelectedNode.Parent);
                        pt_table_changer(panel_table_list);
                        info.Log("DROP TABLE `" + db_tree_list.SelectedNode.Text + "`");
                    }
                    else
                    {
                        InfoShow.Error("Ошибка удаления таблицы");
                        info.Log(DB.Error);
                        return;
                    }
                }
            }
        }

        private void button_sql_execute_Click(object sender, EventArgs e)
        {
            SqlQueryStatus result = DB.ReadInCache(sql_input.Text);
            if (result != SqlQueryStatus.Error)
            {
                if (result == SqlQueryStatus.Ok) pt_table_changer(panel_table_data);
                info.Log(sql_input.Text);
            }
            else
            {
                InfoShow.Error("Ошибка запроса");
                info.Log(DB.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (db_tree_list.SelectedNode.Parent == null)
            {
                InfoShow.Alert("Пока не арбайтен");
            }
            else
            {
                if(search_input.Text == "")
                {
                    pt_table_changer(panel_table_data);
                    DB.ReadInCache("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`", db_tree_list.SelectedNode.Text);
                    return;
                }
                string sql = "SELECT * FROM `" + db_tree_list.SelectedNode.Text + "` WHERE ";
                using (MySqlDataReader reader = DB.Read(
                    "SELECT `COLUMN_NAME`" +
                    "FROM `information_schema`.`COLUMNS`" +
                    "WHERE `TABLE_SCHEMA` = '" + DB.Database + "' AND `TABLE_NAME` = '" + db_tree_list.SelectedNode.Text + "'"
                ))
                {
                    while (reader.Read())
                    {
                        string column_name = reader.GetString(0);
                        sql += "`" + column_name + "` LIKE '%" + search_input.Text + "%' OR";
                    }
                    if (reader.HasRows) sql = sql.Remove(sql.Length - 3);
                }
                SqlQueryStatus result = DB.ReadInCache(sql);
                pt_table_changer(panel_table_data);
            }
        }
    }
}
