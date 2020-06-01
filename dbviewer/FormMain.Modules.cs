using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormMain : Form
    {
        private void UpdateDBTree()
        {
            using (DbDataReader reader = DB.Read("SHOW DATABASES"))
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

        private void pt_table_changer(Panel name)
        {
            ct_list.Clear();
            ct_create.Clear();
            textbox_table_name.Text = "";
            if(db_tree_list.SelectedNode.Parent == null)
            {
                tool_panel_tsb1.Visible = false;
                tool_panel_tsb2.Visible = true;
                tool_panel_tsb3.Visible = true;
                tool_panel_tsb4.Visible = true;
                tool_panel_tsb5.Visible = false;
                tool_panel_tsb6.Visible = true;
                tool_panel_tsb7.Visible = true;
                tool_panel_tsb8.Visible = false;
                tool_panel_tsb9.Visible = true;
            } else
            {
                tool_panel_tsb1.Visible = true;
                tool_panel_tsb2.Visible = true;
                tool_panel_tsb3.Visible = false;
                tool_panel_tsb4.Visible = true;
                tool_panel_tsb5.Visible = true;
                tool_panel_tsb6.Visible = false;
                tool_panel_tsb7.Visible = false;
                tool_panel_tsb8.Visible = true;
                tool_panel_tsb9.Visible = false;
            }

            pt_table_func.ChangeActivePanel(name);
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
            log_label.Text += "[" + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + "] " + message + "\r\n";
            log_panel.AutoScrollPosition = new Point(0, log_label.Height);
        }

        private string ListSqlStringJoin(List<string> list)
        {
            string tmp = "";
            for (int i = 0; i < list.Count; i++)
            {
                tmp += "`" + list[i] + "`";
                if (i < list.Count - 1) tmp += ",";
            }
            return tmp;
        }
    }
}
