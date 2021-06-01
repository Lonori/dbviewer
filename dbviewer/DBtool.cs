using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace dbviewer
{
    public class DBtool
    {
        private MySqlConnection connection;
        private MySqlDataAdapter data_adapter;
        private MySqlCommandBuilder command_builder;
        private DataSet data_cache;
        private int _AffectedRows = 0;
        private string _ConnectError = "";
        private string _Error = "";
        private int _Port;

        private DBtool(string connectionString)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                data_adapter = new MySqlDataAdapter();
                command_builder = new MySqlCommandBuilder(data_adapter);
                data_cache = new DataSet();
            }
            catch (Exception e)
            {
                _ConnectError = e.Message;
            }
        }

        public DBtool(string host, string username, string passwd) : this(host, username, passwd, 3306)
        { }

        public DBtool(string host, string username, string passwd, int port) :
        this("Server=" + host + ";port=" + port + ";User Id=" + username + ";password=" + passwd + ";charset=utf8mb4;")
        {
            _Port = port;
        }

        public int AffectedRows
        {
            get { return _AffectedRows; }
        }
        public string ConnectError
        {
            get { return _ConnectError; }
        }
        public string Database
        {
            get { return connection.Database; }
        }
        public string Error
        {
            get { return _Error; }
        }
        public string HostInfo
        {
            get { return connection.DataSource; }
        }
        public int Port
        {
            get { return _Port; }
        }

        public delegate void backupComplete(object sender, ExportCompleteArgs e);
        public delegate void restoreComplete(object sender, ImportCompleteArgs e);

        public event backupComplete BackupComplete;
        public event restoreComplete RestoreComplete;

        public void Close()
        {
            connection.Close();
            connection.Dispose();
        }

        public bool ReadFromCache(DataGridView dataGrid)
        {
            if(data_cache.Tables.Count > 0)
            {
                dataGrid.DataSource = data_cache.Tables[0];
                return true;
            }
            return false;
        }

        public SqlQueryStatus ReadIntoCache(string query)
        {
            try
            {
                data_cache.Tables.Clear();
                data_adapter.SelectCommand = new MySqlCommand(query, connection);
                data_adapter.Fill(data_cache);
                if (data_cache.Tables.Count > 0)
                {
                    return SqlQueryStatus.Ok;
                }
                return SqlQueryStatus.NonQuery;
            }
            catch (Exception e)
            {
                _Error = e.Message;
            }
            return SqlQueryStatus.Error;
        }

        public bool HasChanges()
        {
            return data_cache.HasChanges();
        }

        public bool SaveChange()
        {
            try
            {
                data_adapter.Update(data_cache);
                data_cache.Clear();
                data_adapter.Fill(data_cache);
                return true;
            }
            catch (Exception e)
            {
                _Error = e.Message;
            }
            return false;
        }

        public MySqlDataReader Read(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                _Error = e.Message;
            }
            return null;
        }

        public bool Write(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                _AffectedRows = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                _Error = e.Message;
            }
            return false;
        }

        public bool SelectDB(string dbname)
        {
            try
            {
                connection.ChangeDatabase(dbname);
                return true;
            }
            catch (Exception e)
            {
                _Error = e.Message;
            }
            return false;
        }

        public void Backup(string file_path)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = connection;
                    mb.ExportCompleted += backup_complete;
                    mb.ExportToFile(file_path);
                }
            }
        }

        public void Restore(string file_path)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = connection;
                    mb.ImportCompleted += restore_complete;
                    mb.ImportFromFile(file_path);
                }
            }
        }

        private void backup_complete(object sender, ExportCompleteArgs e)
        {
            BackupComplete?.Invoke(sender, e);
        }

        private void restore_complete(object sender, ImportCompleteArgs e)
        {
            RestoreComplete?.Invoke(sender, e);
        }
    }

    public enum SqlQueryStatus
    {
        Error,
        Ok,
        NonQuery,
        Empty
    }
}
