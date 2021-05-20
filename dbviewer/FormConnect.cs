using System;
using System.IO;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormConnect : Form
    {
        private string host;
        private string port;
        public bool ClickedButton = false;

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
                                host = line;
                                break;
                            case 2:
                                if (line != "3306") input_host.Text += ":" + line;
                                port = line;
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

        public string Hostname
        {
            get { return host; }
        }
        public string Port
        {
            get { return port; }
        }
        public string Username
        {
            get { return input_user.Text.Trim(); }
        }
        public string Password
        {
            get { return input_pass.Text.Trim(); }
        }
        public string Status
        {
            set { label_status.Text = value; }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (save_login_check.Checked)
            {
                string[] words = input_host.Text.Trim().Split(new char[] { ':' });
                string file = words[0];
                host = words[0].Trim();
                if (words.Length == 1)
                {
                    file += "\n3306";
                    port = "3306";
                }
                if (words.Length == 2)
                {
                    file += "\n" + words[1].Trim();
                    port = words[1].Trim();
                }
                file += "\n" + input_user.Text.Trim() + "\n" + input_pass.Text.Trim();
                try
                {
                    using (StreamWriter sw = new StreamWriter("auth", false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(file);
                    }
                }
                catch (Exception er)
                {
                    InfoShow.Error(er.Message);
                }
            }
            ClickedButton = true;
            Close();
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
