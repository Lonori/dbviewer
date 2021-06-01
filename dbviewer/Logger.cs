using System;
using System.Windows.Forms;

namespace dbviewer
{
    public class Logger
    {
        private TextBox log_box;

        public Logger(TextBox log_box)
        {
            this.log_box = log_box;
        }

        public static void Info(string message)
        {
            MessageBox.Show(
                message,
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        public static void Error(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }

        public static void Warning(string message)
        {
            MessageBox.Show(
                message,
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1
            );
        }

        public static bool Confirm(string message)
        {
            switch (MessageBox.Show(message,
                "Подтвердите действие",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            ))
            {
                case DialogResult.Yes: return true;
                default: return false;
            }
        }

        public static int ConfirmCancel(string message)
        {
            switch (MessageBox.Show(message,
                "Подтвердите действие",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3
            ))
            {
                case DialogResult.Yes: return 2;
                case DialogResult.No: return 1;
                default: return 0;
            }
        }

        public void Log(string message)
        {
            log_box.Text += "[" + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + "] " + message + "\r\n";
            log_box.SelectionStart = log_box.TextLength;
            log_box.ScrollToCaret();
        }
    }
}
