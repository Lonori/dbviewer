using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace bdviewer
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

        private void UpdateDBTree()
        {
            using (DbDataReader reader = DB.Read("SHOW DATABASES"))
            {
                treeView1.Nodes.Clear();
                while (reader.Read())
                {
                    string db_name = reader.GetString(0);
                    if (db_name == "information_schema") continue;
                    treeView1.Nodes.Add(db_name);
                }
            }
        }

        private void change_panel1(string name)
        {
            for (int i = 0; i < panels1.Length; i++)
            {
                if (name == panels1[i].Name)
                {
                    panels1[i].Visible = true;
                }
                else
                {
                    panels1[i].Visible = false;
                }
            }
        }

        private void change_panel2(string name)
        {
            ct_list.Clear();
            ct_create.Clear();

            for (int i = 0; i < panels2.Length; i++)
            {
                if (name == panels2[i].Name)
                {
                    panels2[i].Visible = true;
                    if (name == "panel_table_create") ct_create.AddRow();
                }
                else
                {
                    panels2[i].Visible = false;
                }
            }
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
            DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss K");
            log_label.Text += "[" + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + "] " + message + "\r\n";
            log_panel.AutoScrollPosition = new Point(0, log_label.Height);
        }
    }
}
