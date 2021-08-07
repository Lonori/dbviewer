using System;
using System.IO;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormConnect : Form
    {
        private DBtool _DBConnection;

        public DBtool DBConnection
        {
            get { return _DBConnection; }
        }

        public FormConnect()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader("auth", System.Text.Encoding.UTF8))
                {
                    string line;
                    int coun = 1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (coun)
                        {
                            case 1:
                                input_host.Text = line;
                                break;
                            case 2:
                                if (line != "3306") input_host.Text += ":" + line;
                                break;
                            case 3:
                                input_user.Text = line;
                                break;
                            case 4:
                                input_pass.Text = line;
                                break;
                        }
                        coun++;
                    }
                    save_login_check.Checked = true;
                }
            }
            catch
            { }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string host;
            string username;
            string password;
            int port;

            label_status.Text = "";
            Cursor = Cursors.WaitCursor;

            string[] host_arr = input_host.Text.Trim().Split(new char[] { ':' });
            switch (host_arr.Length)
            {
                case 1:
                    port = 3306;
                    break;
                case 2:
                    try
                    {
                        port = int.Parse(host_arr[1].Trim());
                    }
                    catch
                    {
                        Logger.Info("Неверный формат порта сервера");
                        return;
                    }
                    break;
                default:
                    Logger.Info("Неверный формат адреса сервера");
                    return;
            }
            host = host_arr[0].Trim();
            username = input_user.Text.Trim();
            password = input_pass.Text.Trim();

            if (save_login_check.Checked)
            {
                string auth_file_data = host + "\n" + port + "\n" + username + "\n" + password;
                try
                {
                    using (StreamWriter sw = new StreamWriter("auth", false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(auth_file_data);
                    }
                }
                catch (Exception er)
                {
                    Logger.Error(er.Message);
                }
            }

            DBtool DBConnection = new DBtool(host, username, password, port);
            if (DBConnection.ConnectError == "")
            {
                Cursor = Cursors.Default;
                this._DBConnection = DBConnection;
                Close();
            }
            else
            {
                Cursor = Cursors.Default;
                label_status.Text = DBConnection.ConnectError;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            input_pass.UseSystemPasswordChar = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            input_pass.UseSystemPasswordChar = true;
        }
    }
}
