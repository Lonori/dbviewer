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
    public partial class PanelTableData : UserControl
    {
        private DBtool DB;
        private Logger Logger;

        public DataGridView DataGrid
        {
            get { return table_query_result; }
        }

        public PanelTableData(DBtool database, Logger logger)
        {
            DB = database;
            Logger = logger;
            InitializeComponent();
        }

        public void ReadIntoTable()
        {
            DB.ReadFromCache(table_query_result);
        }

        public void ReadIntoTable(string query)
        {
            DB.ReadIntoCache(query);
            ReadIntoTable();
        }

        public void ReadIntoTable(string query, string table_name)
        {
            ReadIntoTable(query);
            using (MySqlDataReader reader = DB.Read("SELECT `COLUMN_NAME`,`COLUMN_COMMENT` FROM `information_schema`.`COLUMNS` WHERE `TABLE_SCHEMA` = '" + DB.Database + "' AND `TABLE_NAME` = '" + table_name + "'"))
            {
                while (reader.Read())
                {
                    string column_name = reader.GetString(0);
                    string column_comment = reader.GetString(1);
                    if (column_comment == "") continue;
                    for (int i = 0; i < table_query_result.Columns.Count; i++)
                    {
                        if (table_query_result.Columns[i].Name == column_name)
                        {
                            table_query_result.Columns[i].HeaderText = column_comment;
                            break;
                        }
                    }
                }
            }
        }

        public void Save()
        {
            table_query_result.EndEdit();
            table_query_result.CurrentCell = null;
            if (!DB.HasChanges()) return;
            if (DB.SaveChange())
            {
                Logger.Log("Изменения успешно сохранены");
            }
            else
            {
                Logger.Error("Ошибка сохранения");
                Logger.Log(DB.Error);
            }
        }

        public bool ChangeChecker()
        {
            table_query_result.EndEdit();
            table_query_result.CurrentCell = null;
            if (DB.HasChanges())
            {
                switch (Logger.ConfirmCancel("Есть несохраненные изменения. Сохранить изменения перед выходом?"))
                {
                    case 1: break;
                    case 2:
                        if (DB.SaveChange())
                        {
                            Logger.Log("Изменения успешно сохранены");
                        }
                        else
                        {
                            Logger.Error("Ошибка сохранения");
                            Logger.Log(DB.Error);
                            return false;
                        }
                        break;
                    default: return false;
                }
            }
            return true;
        }

        private void table_query_result_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context.HasFlag(DataGridViewDataErrorContexts.LeaveControl))
            {
                table_query_result.CancelEdit();
            }
            else
            {
                Logger.Error(e.Exception.Message);
            }
        }
    }
}
