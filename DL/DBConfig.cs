using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace MID.DL
{
    internal class DBConfig
    {
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;database=ProjectB;Integrated Security=True";
        private SqlConnection Connection;
        private SqlCommand Command;
        private SqlDataAdapter Adapter;
        private DataTable Table;
        public DBConfig()
        {
            Connection = new SqlConnection(ConnectionString);
        }
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
        }
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }
        public DataTable GetData(string query)
        {
            try
            {
                OpenConnection();
                Adapter = new SqlDataAdapter(query, Connection);
                Table = new DataTable();
                Adapter.Fill(Table);
                Connection.Close();
                return Table;
            }
            catch(Exception ex)
            {
                Connection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool ExecuteCommand(string query)
        {
            try
            {
                Connection.Open();
                Command = new SqlCommand(query, Connection);
                int RowsAffected = Command.ExecuteNonQuery();
                Connection.Close();
                return RowsAffected > 0;
            }
            catch(Exception ex)
            {
                   Connection.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool ExecuteCommand(SqlCommand cmd)
        {
            try
            {
                Connection.Open();
                cmd.Connection = Connection;
                int RowsAffected = cmd.ExecuteNonQuery();
                Connection.Close();
                return RowsAffected > 0;
            }
            catch(Exception ex)
            {
                Connection.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public SqlConnection GetConnection()
        {
            return Connection;
        }
    }
}
