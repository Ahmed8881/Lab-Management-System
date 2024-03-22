using MID.DL;
using System.Data;
class AttendanceDL
{
    private static DBConfig dBConfig = new DBConfig();
    private static List<string> GetRegNo()
    {
        string query = "SELECT RegistrationNumber FROM Student";
        DataTable dt = dBConfig.GetData(query);
        List<string> regNos = new List<string>();
        foreach (DataRow dr in dt.Rows)
        {
            regNos.Add(dr["RegistrationNo"].ToString());
        }
        return regNos;
    }
    private static List<string> GetStatuses()
    {
        string query = "Select Name From Lookup Where Category = 'ATTENDANCE_STATUS'";
        DataTable dt = dBConfig.GetData(query);
        List<string> statuses = new List<string>();
        foreach (DataRow dr in dt.Rows)
        {
            statuses.Add(dr["Name"].ToString());
        }
        return statuses;
    }
}