using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdviewer
{
    public partial class FormMain : Form
    {
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDBTree();
            panels1 = new Panel[] { panel_crdb, panel_tables, panel_table };
            panels2 = new Panel[] { panel_table_create, panel_table_list };
            ct_create = new Table2(table_creator, new string[] { "Таблица", "Сравнение", "Тип", "Строки", "Действия" });
            ct_create.RowHeight = 40;
            ct_list = new Table1(table_tables, new string[] { "Имя", "Тип", "Размер", "Индекс", "Подпись" });
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
            change_panel1("panel_crdb");
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
    }
}
