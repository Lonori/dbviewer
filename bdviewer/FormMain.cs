using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bdviewer
{
    public partial class FormMain : Form
    {
        private MySqlConnection conn;

        public FormMain()
        {
            FormConnect form = new FormConnect();
            bool connected = false;
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

                string host = form.Hostname;
                int port = 3306;
                string database = "main";
                string username = form.Username;
                string password = form.Password;

                try
                {
                    conn = DBMySQLUtils.GetDBConnection(host, port, database, username, password);
                    conn.Open();
                    connected = true;
                }
                catch (Exception error)
                {
                    form.Status = error.Message;
                }
            } while (connected != true);
            form.Dispose();

            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDBTree();
            }
            catch (Exception error)
            {
                MessageBox.Show(
                     error.Message,
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1
                );
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                MySqlCommand cmd = new MySqlCommand("SHOW TABLES FROM `" + e.Node.Text + "`", conn);
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = reader.GetName(i);
                        column.MinimumWidth = 400;
                        dataGridView1.Columns.Add(column);
                    }
                    while (reader.Read())
                    {
                        string table_name = reader.GetString(0);
                        dataGridView1.Rows.Add(new object[] { table_name });
                    }
                }
                label1.Text = "true";
            } else
            {
                conn.ChangeDatabase(e.Node.Parent.Text);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `"+ e.Node.Text + "` WHERE 1 LIMIT 25", conn);
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = reader.GetName(i);
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
                
                label1.Text = "false";
            }
        }

        private void UpdateDBTree()
        {
            MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conn);
            List<string> db_names = new List<string>();

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    db_names.Add(reader.GetString(0));
                }
            }

            for (int i = 0; i < db_names.Count; i++)
            {
                cmd = new MySqlCommand("SHOW TABLES FROM `" + db_names[i] + "`", conn);
                TreeNode treeNode = new TreeNode(db_names[i]);
                treeView1.Nodes.Add(treeNode);

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string table_name = reader.GetString(0);
                        treeNode.Nodes.Add(table_name);
                    }
                }
            }
        }
    }
}
