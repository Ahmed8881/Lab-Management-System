using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MID.DL
{
    internal class StudentDL
    {
        private static DBConfig DBConfig = DBConfig.GetInstance();
        private static string GetAllDataQuery = "SELECT s.FirstName,s.LastName,s.Contact,s.Email,s.RegistrationNumber,l.Name as Status FROM Student s JOIN Lookup l ON s.Status = l.LookupId ORDER BY s.FirstName ASC";
        public static DataTable GetStudentData()
        {
            return DBConfig.GetData(GetAllDataQuery);
        }
        private static string GetStatusId(bool Active)
        {
            string StatusQuery = "SELECT LookupId FROM Lookup WHERE Name = '@Active'";
            if (Active)
            {
                StatusQuery = StatusQuery.Replace("@Active", "Active");
            }
            else
            {
                StatusQuery = StatusQuery.Replace("@Active", "InActive");
            }
            DataTable dt = DBConfig.GetData(StatusQuery);
            return dt.Rows[0]["LookupId"].ToString();
        }
        public static bool AddStudent(string FirstName, string LastName, string Contact, string Email, string RegNo, bool Active)
        {
            string StatusId = GetStatusId(Active);
            string query = "Insert into Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) values('@FirstName', '@LastName', '@Contact', '@Email', '@RegNo', '@StatusId')";
            query = query.Replace("@FirstName", FirstName);
            query = query.Replace("@LastName", LastName);
            query = query.Replace("@Contact", Contact);
            query = query.Replace("@Email", Email);
            query = query.Replace("@RegNo", RegNo);
            query = query.Replace("@StatusId", StatusId);
            return DBConfig.ExecuteCommand(query);
        }
        public static bool DeleteStudent(string RegistrationNumber)
        {
            string query = "DELETE FROM Student WHERE RegistrationNumber = '@RegNo'";
            query = query.Replace("@RegNo", RegistrationNumber);
            return DBConfig.ExecuteCommand(query);
        }
        public static bool UpdateStudent(string FirstName, string LastName, string Contact, string Email, string RegNo, bool IsActive)
        {
            string StatusId = GetStatusId(IsActive);
            string query = "UPDATE Student SET FirstName = '@FirstName', LastName = '@LastName', Contact = '@Contact', Email = '@Email', Status = '@StatusId' WHERE RegistrationNumber = '@RegNo'";
            query = query.Replace("@FirstName", FirstName);
            query = query.Replace("@LastName", LastName);
            query = query.Replace("@Contact", Contact);
            query = query.Replace("@Email", Email);
            query = query.Replace("@RegNo", RegNo);
            query = query.Replace("@StatusId", StatusId);
            return DBConfig.ExecuteCommand(query);
        }
        public static DataTable SearchStudent(string RegistrationNumber)
        {
            string query = GetAllDataQuery + " WHERE s.RegistrationNumber = '@RegNo'";
            query = query.Replace("@RegNo", RegistrationNumber);
            return DBConfig.GetData(query);
        }
    }
}
