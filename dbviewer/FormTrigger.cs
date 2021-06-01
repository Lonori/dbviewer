using MySql.Data.MySqlClient;
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
    public partial class FormTrigger : Form
    {
        DBtool DB;
        private string sql = "";

        public string Sql
        {
            get { return sql; }
        }

        public FormTrigger(DBtool DB)
        {
            this.DB = DB;
            InitializeComponent();
        }

        private void FormTrigger_Load(object sender, EventArgs e)
        {
            using (MySqlDataReader reader = DB.Read("SHOW TABLES"))
            {
                if (!reader.HasRows)
                {
                    Logger.Error("В выбранной базе данных нет таблиц");
                    Close();
                    return;
                }
                while (reader.Read())
                {
                    trig_table.Items.Add(reader.GetString(0));
                }
            }
            trig_table.SelectedIndex = 0;
            trig_time.SelectedIndex = 0;
            trig_event.SelectedIndex = 0;
        }

        private void trig_create_Click(object sender, EventArgs e)
        {
            string sql = "CREATE TRIGGER";
            if (trig_name.TextLength == 0)
            {
                Logger.Warning("Имя триггера не может быть пустым");
                return;
            }
            sql += " `" + trig_name.Text + "` " +
                trig_time.Text + " " +
                trig_event.Text + " ON `" +
                trig_table.Text + "` FOR EACH ROW";
            if (trig_body.TextLength == 0)
            {
                Logger.Warning("Тело триггера не может быть пустым");
                return;
            }
            sql += " " + trig_body.Text;
            if (!DB.Write(sql))
            {
                Logger.Error(DB.Error);
                return;
            }
            this.sql = sql;
            Close();
        }
    }
}
