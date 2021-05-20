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
        private InfoShow Logger;

        private PanelDbView Panel_DbView;
        
        public FormMain()
        {
            FormConnect form_connect = new FormConnect();
            bool connected = false;
            string host;
            string port;
            do
            {
                form_connect.ShowDialog();
                if (form_connect.ClickedButton)
                {
                    form_connect.ClickedButton = false;
                }
                else
                {
                    Dispose();
                    return;
                }

                host = form_connect.Hostname;
                port = form_connect.Port;
                string username = form_connect.Username;
                string password = form_connect.Password;

                DB = new DBtool(host, username, password);
                if (DB.ConnectError == "")
                {
                    connected = true;
                }
                else
                {
                    form_connect.Status = DB.ConnectError;
                }
            } while (connected != true);
            form_connect.Dispose();

            InitializeComponent();

            Logger = new InfoShow(log_box);
            Text = host + ":" + port + " | DB Viewer";
            Logger.Log(host + ":" + port + " - Подключение успешно");

            Panel_DbView = new PanelDbView(DB, Logger);
            Panel_DbView.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Panel_DbView);
            UpdateDBTree();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Panel_DbView.ChangeChecker())
            {
                e.Cancel = true;
                return;
            }
            DB.Close();
        }

        private void mms_tsmi21_Click(object sender, EventArgs e)
        {
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "help.chm";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void mms_tsmi22_Click(object sender, EventArgs e)
        {
            FormProgrammInfo fpi = new FormProgrammInfo();
            fpi.ShowDialog();
            fpi.Dispose();
        }

        private void OpenDbCreate_Click(object sender, EventArgs e)
        {
            db_tree_list.SelectedNode = null;
            PanelDbCreate panel = new PanelDbCreate(DB, Logger);
            panel.Dock = DockStyle.Fill;
            panel.OnDbCreate += UpdateDBTree;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(panel);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Panel_DbView.ChangeChecker();
            if(!panelContainer.Controls[0].Equals(Panel_DbView))
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(Panel_DbView);
            }
            if (e.Action != TreeViewAction.Collapse && e.Action != TreeViewAction.Expand && e.Node.Parent == null)
            {
                DB.SelectDB(e.Node.Text);
                Panel_DbView.test1(db_tree_list);
            }
            else
            {
                DB.SelectDB(e.Node.Parent.Text);
                Panel_DbView.test2(e.Node.Text);
            }
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

        private void backup_complete(object sender, ExportCompleteArgs e)
        {
            Cursor = Cursors.Default;
            InfoShow.Alert("Резервное копирование завершено");
            Logger.Log("Резервное копирование завершено (" + e.TimeUsed.ToString("hh\\:mm\\:ss") + ") " + e.LastError);
        }

        private void restore_complete(object sender, ImportCompleteArgs e)
        {
            Cursor = Cursors.Default;
            Panel_DbView.test1(db_tree_list);
            InfoShow.Alert("Восстановление завершено");
            Logger.Log("Восстановление завершено (" + e.TimeUsed.ToString() + ") " + e.LastError);
        }
    }
}
