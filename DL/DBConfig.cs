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
        public DataTable GetData(string query)
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            Adapter = new SqlDataAdapter(query, Connection);
            Table = new DataTable();
            Adapter.Fill(Table);
            Connection.Close();
            return Table;
        }
        public bool ExecuteCommand(string query)
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            Command = new SqlCommand(query, Connection);
            int RowsAffected = Command.ExecuteNonQuery();
            Connection.Close();
            if (RowsAffected > 0)
                return true;
            else
                return false;
        }
    }
}
