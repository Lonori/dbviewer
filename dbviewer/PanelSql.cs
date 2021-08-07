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
    public partial class PanelSql : UserControl
    {
        private DBtool DB;
        private Logger Lr;

        public delegate void EventOnQuery();
        public event EventOnQuery OnQuery;

        public PanelSql(DBtool database, Logger logger)
        {
            DB = database;
            Lr = logger;
            InitializeComponent();
        }

        private void button_sql_execute_Click(object sender, EventArgs e)
        {
            if(sql_input.Text == "")
            {
                Logger.Warning("Поле запроса не может быть пустым");
                return;
            }
            SqlQueryStatus result = DB.ReadIntoCache(sql_input.Text);
            if (result != SqlQueryStatus.Error)
            {
                if (result == SqlQueryStatus.Ok) OnQuery?.Invoke();
                Lr.Log(sql_input.Text);
            }
            else
            {
                Logger.Error("Ошибка запроса");
                Lr.Log(DB.Error);
            }
        }
    }
}
