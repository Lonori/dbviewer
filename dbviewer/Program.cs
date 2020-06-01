using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbviewer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain form = new FormMain();
            if (form == null || form.IsDisposed)
            {
                Application.Exit();
            }
            else
            {
                Application.Run(form);
            }
        }
    }
}
