using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormMain : Form
    {
        private void UpdateDBTree()
        {
            using (MySqlDataReader reader = DB.Read("SHOW DATABASES"))
            {
                db_tree_list.Nodes.Clear();
                while (reader.Read())
                {
                    string db_name = reader.GetString(0);
                    if (db_name == "information_schema") continue;
                    db_tree_list.Nodes.Add(db_name);
                }
            }
        }

        private void UpdateTableTree(TreeNode db_node)
        {
            using (MySqlDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + db_node.Text + "'"))
            {
                db_node.Nodes.Clear();
                while (reader.Read())
                {
                    string table_name = reader.GetString(0);
                    db_node.Nodes.Add(new TreeNode(table_name) { ImageIndex = 1 });
                    ct_list.AddRow(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
                }
                db_node.Expand();
            }
        }

        private bool SaveDB()
        {
            table_query_result.EndEdit();
            table_query_result.CurrentCell = null;
            if (DB.HasChanges())
            {
                switch (InfoShow.ConfirmCancellation("Есть несохраненные изменения. Сохранить изменения перед выходом?"))
                {
                    case 1: break;
                    case 2:
                        if (DB.SaveChange())
                        {
                            info.Log("Изменения успешно сохранены");
                        }
                        else
                        {
                            InfoShow.Error("Ошибка сохранения");
                            info.Log(DB.Error);
                            return false;
                        }
                        break;
                    default: return false;
                }
            }
            return true;
        }

        private void pt_table_changer(Panel panel)
        {
            ct_list.Clear();
            ct_create.Clear();
            sql_input.Clear();
            textbox_table_name.Clear();
            if (!panel_table_data.Equals(panel))
            {
                search_input.Clear();
                SaveDB();
            }
            if (db_tree_list.SelectedNode.Parent == null)
            {
                tool_panel_tsb1.Visible = false;
                tool_panel_tsb2.Visible = false;
                tool_panel_tsb3.Visible = true;
                tool_panel_tsb4.Visible = true;
                tool_panel_tsb5.Visible = true;
                tool_panel_tsb6.Visible = false;
                tool_panel_tsb7.Visible = true;
                tool_panel_tsb8.Visible = true;
                tool_panel_tsb9.Visible = false;
                tool_panel_tsb10.Visible = true;
            }
            else
            {
                if (panel.Equals(panel_table_data))
                {
                    tool_panel_tsb1.Visible = true;
                }
                else
                {
                    tool_panel_tsb1.Visible = false;
                }
                tool_panel_tsb2.Visible = true;
                tool_panel_tsb3.Visible = true;
                tool_panel_tsb4.Visible = false;
                tool_panel_tsb5.Visible = true;
                tool_panel_tsb6.Visible = true;
                tool_panel_tsb7.Visible = false;
                tool_panel_tsb8.Visible = false;
                tool_panel_tsb9.Visible = true;
                tool_panel_tsb10.Visible = false;
            }

            pt_table_func.ChangeActivePanel(panel);
        }
    }
}
