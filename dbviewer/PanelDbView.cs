using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class PanelDbView : UserControl
    {
        private DBtool DB;
        private InfoShow Logger;

        private TreeView db_tree_list;

        private PanelProcedure Panel_Procedure;
        private PanelSql Panel_Sql;
        private PanelTableCreate Panel_TableCreate;
        private PanelTableData Panel_TableData;
        private PanelTableList Panel_TableList;
        private PanelTrigger Panel_Trigger;


        public PanelDbView(DBtool database, InfoShow logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
            Panel_Procedure = new PanelProcedure(DB, Logger) { Dock = DockStyle.Fill };
            Panel_Sql = new PanelSql(DB, Logger) { Dock = DockStyle.Fill };
            Panel_TableCreate = new PanelTableCreate(DB, Logger) { Dock = DockStyle.Fill };
            Panel_TableData = new PanelTableData(DB, Logger) { Dock = DockStyle.Fill };
            Panel_TableList = new PanelTableList(DB, Logger) { Dock = DockStyle.Fill };
            Panel_Trigger = new PanelTrigger(DB, Logger) { Dock = DockStyle.Fill };
            Panel_Procedure.OnProcedureRun += OnPocedureRun_ChangePanel;
            Panel_Sql.OnQuery += OnQuery_ChangePanel;
            Panel_TableCreate.OnTableCreate += OnTableCreate_ChangePanel;
            Panel_TableList.OnTableDelete += OnTableCreate_ChangePanel;
        }

        public void test1(TreeView db_tree_list)
        {
            this.db_tree_list = db_tree_list;
            ChangePanel(Panel_TableList);
            TreeNode db_node;
            if (db_tree_list.SelectedNode.Parent == null) db_node = db_tree_list.SelectedNode;
            else db_node = db_tree_list.SelectedNode.Parent;
            using (MySqlDataReader reader = DB.Read("SELECT `TABLE_NAME`,`ENGINE`,`TABLE_ROWS`,`TABLE_COLLATION` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`='" + db_node.Text + "'"))
            {
                db_node.Nodes.Clear();
                while (reader.Read())
                {
                    string table_name = reader.GetString(0);
                    db_node.Nodes.Add(new TreeNode(table_name) { ImageIndex = 1 });
                    Panel_TableList.AddRow(table_name, reader.GetString(3), reader.GetString(1), reader.GetString(2));
                }
                db_node.Expand();
            }
        }

        public void test2(string text)
        {
            ChangePanel(Panel_TableData);
            Panel_TableData.ReadIntoTable("SELECT * FROM `" + text + "`", text);
            Logger.Log("SELECT * FROM `" + text + "`");
        }

        private void ChangePanel(Control panel)
        {
            if (panel.Equals(Panel_Procedure)) Panel_Procedure.UpdateProcedureList();
            if (panel.Equals(Panel_TableList)) Panel_TableList.Clear();
            if (panel.Equals(Panel_TableCreate)) Panel_TableCreate.Clear();
            if (panel.Equals(Panel_Trigger)) Panel_Trigger.UpdateTriggerList();
            pt_table_changer(panel);

            if (panelContainer.Controls.Count != 0)
            {
                if (panelContainer.Controls[0].Equals(panel)) return;
                panelContainer.Controls.Clear();
            }
            panelContainer.Controls.Add(panel);
        }

        private void OnQuery_ChangePanel()
        {
            ChangePanel(Panel_TableData);
        }

        private void OnTableCreate_ChangePanel()
        {
            test1(db_tree_list);
        }

        private void OnPocedureRun_ChangePanel()
        {
            ChangePanel(Panel_TableData);
            Panel_TableData.ReadIntoTable();
        }

        private void pt_table_changer(Control panel)
        {
            if (!panel.Equals(Panel_TableData))
            {
                search_input.Clear();
                Panel_TableData.ChangeChecker();
            }
            if (db_tree_list.SelectedNode.Parent == null)
            {
                tool_panel_tsb1.Visible = false;
                tool_panel_tsb2.Visible = false;
                tool_panel_tsb3.Visible = false;
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
                if (panel.Equals(Panel_TableData))
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
            tool_panel_tsb3.Visible = false;
            tool_panel_tsb6.Visible = false;
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
                    ChangePanel(Panel_TableData);
                    Panel_TableData.ReadIntoTable("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`", db_tree_list.SelectedNode.Text);
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
                SqlQueryStatus result = DB.ReadIntoCache(sql);
                ChangePanel(Panel_TableData);
                Panel_TableData.ReadIntoTable();
            }
        }

        public bool ChangeChecker()
        {
            return Panel_TableData.ChangeChecker();
        }

        private void tool_panel_tsb1_Click(object sender, EventArgs e)
        {
            Panel_TableData.Save();
        }

        private void tool_panel_tsb2_Click(object sender, EventArgs e)
        {
            ChangePanel(Panel_TableData);
            Panel_TableData.ReadIntoTable("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`", db_tree_list.SelectedNode.Text);
            Logger.Log("SELECT * FROM `" + db_tree_list.SelectedNode.Text + "`");
        }

        private void tool_panel_tsb3_Click(object sender, EventArgs e)
        {

        }

        private void tool_panel_tsb4_Click(object sender, EventArgs e)
        {
            ChangePanel(Panel_TableCreate);
        }

        private void tool_panel_tsb5_Click(object sender, EventArgs e)
        {
            ChangePanel(Panel_Sql);
        }

        private void tool_panel_tsb6_Click(object sender, EventArgs e)
        {

        }

        private void tool_panel_tsb7_Click(object sender, EventArgs e)
        {
            ChangePanel(Panel_Procedure);
        }

        private void tool_panel_tsb8_Click(object sender, EventArgs e)
        {
            ChangePanel(Panel_Trigger);
        }

        private void tool_panel_tsb9_Click(object sender, EventArgs e)
        {
            if (!InfoShow.Confirm("Вы действительно хотите удалить данную таблицу?")) return;
            string sql_text = "DROP TABLE `" + db_tree_list.SelectedNode.Text + "`";
            if (DB.Write(sql_text))
            {
                test1(db_tree_list);
                Logger.Log(sql_text);
            }
            else
            {
                InfoShow.Error("Ошибка удаления таблицы");
                Logger.Log(DB.Error);
                return;
            }
        }

        private void tool_panel_tsb10_Click(object sender, EventArgs e)
        {
            if (!InfoShow.Confirm("Вы действительно хотите удалить данную базу данных?")) return;
            if (DB.Write("DROP DATABASE `" + db_tree_list.SelectedNode.Text + "`"))
            {
                Logger.Log("DROP DATABASE `" + db_tree_list.SelectedNode.Text + "`");
            }
            else
            {
                InfoShow.Error("Ошибка удаления базы данных");
                Logger.Log(DB.Error);
                return;
            }
        }
    }
}
