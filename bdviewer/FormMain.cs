using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace bdviewer
{
    public partial class FormMain : Form
    {
        private MySqlConnection conn;

        public FormMain()
        {
            FormConnect form = new FormConnect();
            bool connected = false;
            string host;
            int port;
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
                port = 3306;
                //string database = "main";
                string username = form.Username;
                string password = form.Password;

                try
                {
                    conn = DBMySQLUtils.GetDBConnection(host, port, /*database,*/ username, password);
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
            this.Text = host + ":" + port + " | DB Viewer";
            Log("Соединение успешно установлено");
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
                ShowMessage(error.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                MySqlCommand cmd = new MySqlCommand("SHOW TABLES FROM `" + e.Node.Text + "`", conn);
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        e.Node.Nodes.Add(reader.GetString(0));
                    }
                    e.Node.Expand();
                }

                Log("True");
            }
            else
            {
                conn.ChangeDatabase(e.Node.Parent.Text);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `" + e.Node.Text + "` WHERE 1 LIMIT 25", conn);
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

                Log("False");
            }
        }

        private void UpdateDBTree()
        {
            MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conn);

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    treeView1.Nodes.Add(reader.GetString(0));
                }
            }
        }

        private void ShowMessage(string message)
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
    }
}
