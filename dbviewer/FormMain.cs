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
        private Table_ListTable ct_db_struct;
        private Table_CreateTable ct_tbl_create;
        private Table_Procedure ct_procedure_list;
        private Table_Trigger ct_trigger_list;
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
            string port;
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
                port = form.Port;
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
            Text = host + ":" + port + " | DB Viewer";
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
            pt_table_func = new PanelTriger(new Panel[] {
                panel_table_create,
                panel_db_structure,
                panel_sql_result,
                panel_sql,
                panel_procedure_list,
                panel_trigger_list
            });
            ct_db_struct = new Table_ListTable(table_tables);
            ct_tbl_create = new Table_CreateTable(table_creator);
            ct_procedure_list = new Table_Procedure(table_procedure);
            ct_trigger_list = new Table_Trigger(table_trigger);

            info.Log(DB.HostInfo + " - Подключение успешно");
            DB.DataGridInclude(table_query_result);
            UpdateDBTree();

            ct_tbl_create.RowHeight = 40;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                DB.SelectDB(e.Node.Text);
                pt_db_func.ChangeActivePanel(panel_database);
                pt_table_changer(panel_db_structure);
                UpdateTableTree();
            }
            else
            {
                pt_db_func.ChangeActivePanel(panel_database);
                pt_table_changer(panel_sql_result);

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
            db_tree_list.SelectedNode = null;
            pt_db_func.ChangeActivePanel(panel_db_create);
        }

        private void button_add_column_Click(object sender, EventArgs e)
        {
            ct_tbl_create.AddRow();
        }

        private void button_table_create_Click(object sender, EventArgs e)
        {
            if (textbox_table_name.TextLength == 0)
            {
                InfoShow.Warning("Название таблицы не может быть пустым");
                return;
            }
            int amount = 0;
            for (int i = 0; i < ct_tbl_create.Length; i++) if (ct_tbl_create[i][0].Text.Length > 0) amount++;
            if (amount <= 0)
            {
                InfoShow.Warning("Таблица не содержит ни одного поля");
                return;
            }
            List<string> ind_primary = new List<string>();
            string sql = "CREATE TABLE";
            sql += " `" + textbox_table_name.Text + "` (";
            for (int i = 0; i < ct_tbl_create.Length; i++)
            {
                if (ct_tbl_create[i][0].Text.Length <= 0) continue;
                sql += "`" + ct_tbl_create[i][0].Text + "` " + ((ComboBox)ct_tbl_create[i][1]).SelectedItem.ToString();
                if (ct_tbl_create[i][2].Text.Length > 0)
                {
                    try
                    {
                        sql += "(" + int.Parse(ct_tbl_create[i][2].Text) + ")";
                    }
                    catch
                    {
                        InfoShow.Warning("Неверно указан размер поля");
                        return;
                    }
                }
                sql += " NOT NULL";
                switch (((ComboBox)ct_tbl_create[i][3]).SelectedItem.ToString())
                {
                    case "PRIMARY": ind_primary.Add(ct_tbl_create[i][0].Text); break;
                }
                if (ct_tbl_create[i][4].Text.Length > 0)
                {
                    sql += " COMMENT '" + ct_tbl_create[i][4].Text + "'";
                }
                sql += ",";
            }
            sql = sql.Remove(sql.Length - 1);
            if (ind_primary.Count > 0) sql += ", PRIMARY KEY (`" + string.Join("`,`", ind_primary) + "`)";
            sql += ") ENGINE = InnoDB";
            if (DB.Write(sql))
            {
                pt_table_changer(panel_db_structure);
                UpdateTableTree();
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

        private void button_sql_execute_Click(object sender, EventArgs e)
        {
            DBtool.SqlQueryStatus result = DB.ReadInCache(sql_input.Text);
            if (result != DBtool.SqlQueryStatus.Error)
            {
                if (result == DBtool.SqlQueryStatus.Ok) pt_table_changer(panel_sql_result);
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
                if (search_input.Text == "")
                {
                    pt_table_changer(panel_sql_result);
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
                DBtool.SqlQueryStatus result = DB.ReadInCache(sql);
                pt_table_changer(panel_sql_result);
            }
        }

        private void button_proc_create_Click(object sender, EventArgs e)
        {
            FormProcedure fp = new FormProcedure(DB);
            fp.ShowDialog();
            if (fp.Sql != "")
            {
                ct_procedure_list.Clear();
                UpdateProcedureList();
                info.Log(fp.Sql);
            }
            fp.Dispose();
        }

        private void button_trig_create_Click(object sender, EventArgs e)
        {
            FormTrigger ft = new FormTrigger(DB);
            ft.ShowDialog();
            if (ft.Sql != "")
            {
                ct_procedure_list.Clear();
                UpdateTriggerList();
                info.Log(ft.Sql);
            }
            ft.Dispose();
        }

        private void mms_tsmi22_Click(object sender, EventArgs e)
        {
            FormProgrammInfo fpi = new FormProgrammInfo();
            fpi.ShowDialog();
            fpi.Dispose();
        }

        private void mms_tsmi11_Click(object sender, EventArgs e)
        {
            file_save_dialog.FileName = DB.Database + ".sql";
            if (file_save_dialog.ShowDialog() != DialogResult.OK) return;
            Cursor = Cursors.WaitCursor;
            DB.BackupComplete += backup_complete;
            DB.Backup(file_save_dialog.FileName);
        }

        private void mms_tsmi12_Click(object sender, EventArgs e)
        {
            if (file_open_dialog.ShowDialog() != DialogResult.OK) return;
            Cursor = Cursors.WaitCursor;
            DB.RestoreComplete += restore_complete;
            DB.Restore(file_open_dialog.FileName);
        }

        private void tool_panel_tsb_Click(object sender, EventArgs e)
        {
            ToolStripButton elem = (ToolStripButton)sender;
            if (elem.Name == "tool_panel_tsb5") pt_table_changer(panel_sql);
            if (db_tree_list.SelectedNode.Parent == null)
            {
                if (elem.Name == "tool_panel_tsb3")
                {
                    pt_table_changer(panel_db_structure);
                    UpdateTableTree();
                }
                if (elem.Name == "tool_panel_tsb4")
                {
                    pt_table_changer(panel_table_create);
                    ct_tbl_create.AddRow();
                }
                if (elem.Name == "tool_panel_tsb7")
                {
                    pt_table_changer(panel_procedure_list);
                    UpdateProcedureList();
                }
                if (elem.Name == "tool_panel_tsb8")
                {
                    pt_table_changer(panel_trigger_list);
                    UpdateTriggerList();
                }
                if (elem.Name == "tool_panel_tsb10")
                {
                    if (!InfoShow.Confirm("Вы действительно хотите удалить данную базу данных?")) return;
                    if (DB.Write("DROP DATABASE `" + db_tree_list.SelectedNode.Text + "`"))
                    {
                        info.Log("DROP DATABASE `" + db_tree_list.SelectedNode.Text + "`");
                    }
                    else
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
                    pt_table_changer(panel_sql_result);
                    DB.ReadInCache("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`", db_tree_list.SelectedNode.Text);
                    info.Log("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`");
                }
                if (elem.Name == "tool_panel_tsb9")
                {
                    if (!InfoShow.Confirm("Вы действительно хотите удалить данную таблицу?")) return;
                    string sql_text = "DROP TABLE `" + db_tree_list.SelectedNode.Text + "`";
                    if (DB.Write(sql_text))
                    {
                        pt_table_changer(panel_db_structure);
                        UpdateTableTree();
                        info.Log(sql_text);
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

        private void mms_tsmi21_Click(object sender, EventArgs e)
        {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "help.chm";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
