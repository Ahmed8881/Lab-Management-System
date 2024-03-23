using MID.DL;
using System.Data;
using System.Data.SqlClient;
class AttendanceDL
{
    private static DBConfig dBConfig = new DBConfig();
    public static List<string> GetRegNo()
    {
        string query = "SELECT RegistrationNumber FROM Student";
        DataTable dt = dBConfig.GetData(query);
        List<string> regNos = new List<string>();
        foreach (DataRow dr in dt.Rows)
        {
            regNos.Add(dr["RegistrationNumber"].ToString());
        }
        return regNos;
    }
    public static List<string> GetStatuses()
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
    public static bool SaveAttendance(AttendanceBL attendance)
    {
        string query = "Insert into StudentAttendance(StudentID, AttendanceStatus, AttendanceID) values(@StudentID, @StatusID, @AttendanceID)";
        query = query.Replace("@StudentID", attendance.GetStudentID().ToString());
        query = query.Replace("@StatusID", attendance.GetStatusID().ToString());
        query = query.Replace("@AttendanceID", attendance.GetAttendanceID().ToString());
        return dBConfig.ExecuteCommand(query);
    }
    public static DataTable GetAttendance()
    {
        string query = "Select s.RegistrationNumber, l.Name, ca.AttendanceDate from StudentAttendance a join Student s on a.StudentId = s.Id join Lookup l on a.AttendanceStatus = l.LookupID join ClassAttendance ca on a.AttendanceID = ca.Id";
        return dBConfig.GetData(query);
    }
}