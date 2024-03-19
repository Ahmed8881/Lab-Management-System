using System.Data;
using System.Data.SqlClient;
namespace MID.DL
{
    class CloDL
    {
        private static DBConfig DBConfig = DBConfig.GetInstance();
        private static string GetAllDataQuery = "SELECT * FROM Clo";
        public static DataTable GetCloData()
        {
            return DBConfig.GetData(GetAllDataQuery);
        }
        public static bool AddClo(string Name, DateTime DateCreated)
        {
            string query = "Insert into Clo(Name, DateCreated, DateUpdated) values(@Name, @DateCreated, @DateCreated)";
            using SqlConnection con = DBConfig.GetConnection();
            DBConfig.OpenConnection();
            using var command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateCreated", DateCreated);
            DBConfig.CloseConnection();
            return command.ExecuteNonQuery() > 0;
        }
        public static bool DeleteClo(int Id)
        {
            string query = "DELETE FROM Clo WHERE Id = '@Id'";
            query = query.Replace("@Id", Id.ToString());
            return DBConfig.ExecuteCommand(query);
        }
        public static bool UpdateClo(int Id, string Name, DateTime DateUpdated)
        {
            string query = "UPDATE Clo SET Name = '@Name', DateUpdated = '@DateUpdated' WHERE Id = '@Id'";
            using SqlConnection con = DBConfig.GetConnection();
            DBConfig.OpenConnection();
            using var command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateUpdated", DateUpdated);
            command.Parameters.AddWithValue("@Id", Id);
            DBConfig.CloseConnection();
            return command.ExecuteNonQuery() > 0;
        }
    }
}