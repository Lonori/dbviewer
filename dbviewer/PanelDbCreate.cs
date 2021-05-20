using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbviewer
{
    public partial class PanelDbCreate : UserControl
    {
        private DBtool DB;
        private InfoShow Logger;

        public delegate void EventOnDbCreate();
        public event EventOnDbCreate OnDbCreate;

        public PanelDbCreate(DBtool database, InfoShow logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
        }

        private void create_database_Click(object sender, EventArgs e)
        {
            if (name_new_db.TextLength == 0)
            {
                InfoShow.Warning("Имя базы данных не может быть пустым");
                return;
            }
            if (DB.Write("CREATE DATABASE `" + name_new_db.Text + "` charset=utf8mb4"))
            {
                Logger.Log("CREATE DATABASE `" + name_new_db.Text + "` charset=utf8mb4");
                Logger.Log("База данных '" + name_new_db.Text + "' успешно создана");
                name_new_db.Clear();
                OnDbCreate?.Invoke();
            }
            else
            {
                InfoShow.Error("Ошибка создания базы данных");
                Logger.Log(DB.Error);
            }
        }
    }
}
