using System;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class FormProgrammInfo : Form
    {
        public FormProgrammInfo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Lonori/dbviewer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
