using MID.DL;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

class AttendanceBL
{
    private static DBConfig dBConfig = new DBConfig();
    private string RegNo;
    private string Status;
    private DateTime Date;
    public AttendanceBL(string regNo, string status, DateTime date)
    {
        RegNo = regNo;
        Status = status;
        Date = date;
    }
    public int GetStudentID()
    {
        string query = "SELECT Id FROM Student WHERE RegistrationNumber = '" + RegNo + "'";
        dBConfig.OpenConnection();
        DataTable dt = dBConfig.GetData(query);
        dBConfig.CloseConnection();
        return Convert.ToInt32(dt.Rows[0]["Id"]);
    }
    public int GetStatusID()
    {
        string query = "SELECT LookupID FROM Lookup WHERE Name = '" + Status + "'";
        dBConfig.OpenConnection();
        DataTable dt = dBConfig.GetData(query);
        dBConfig.CloseConnection();
        return Convert.ToInt32(dt.Rows[0]["LookupID"]);
    }
    public int GetAttendanceID()
    {
        string query = "Select Id from ClassAttendance where AttendanceDate = @Date";
        dBConfig.OpenConnection();
        SqlCommand cmd = new SqlCommand(query, dBConfig.GetConnection());
        cmd.Parameters.AddWithValue("@Date", Date);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        // if id is null then insert the date
        if (dt.Rows.Count == 0)
        {
            query = "Insert into ClassAttendance(AttendanceDate) values(@Date)";
            cmd = new SqlCommand(query, dBConfig.GetConnection());
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.ExecuteNonQuery();
            return GetAttendanceID();
        }
        dBConfig.CloseConnection();
        return Convert.ToInt32(dt.Rows[0]["Id"]);
    }
}