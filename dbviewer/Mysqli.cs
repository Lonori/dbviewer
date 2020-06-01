using MySql.Data.MySqlClient;
using System;

namespace dbviewer
{
    class Mysqli
    {
        public MySqlConnection conn;
        private int affected_rows = 0;
        private string connect_error = "";
        private string error = "";

        public int AffectedRows
        {
            get { return affected_rows; }
        }
        public string ConnectError
        {
            get { return connect_error; }
        }
        public string Error
        {
            get { return error; }
        }
        public string HostInfo
        {
            get { return conn.DataSource; }
        }

        private Mysqli(string connectionString)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception er)
            {
                connect_error = er.Message;
            }
        }

        public Mysqli(string host, string username, string passwd) : this("Server=" + host + ";port=3306;User Id=" + username + ";password=" + passwd + ";charset=utf8mb4;")
        { }

        public Mysqli(string host, string username, string passwd, int port) : this("Server=" + host + ";port=" + port + ";User Id=" + username + ";password=" + passwd + ";charset=utf8mb4;")
        { }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public MySqlDataReader Read(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteReader();
            }
            catch (Exception er)
            {
                error = er.Message;
            }
            return null;
        }

        public bool Write(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                affected_rows = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                error = er.Message;
            }
            return false;
        }

        public bool SelectDB(string dbname)
        {
            try
            {
                conn.ChangeDatabase(dbname);
                return true;
            }
            catch (Exception er)
            {
                error = er.Message;
            }
            return false;
        }
    }
}
