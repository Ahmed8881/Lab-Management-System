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
        private static DBConfig DBConfig = new DBConfig();
        public static DataTable GetStudentData()
        {
            string query = "SELECT * FROM Student";
            return DBConfig.GetData(query);
        }
        public static int AddStudent(string FirstName, string LastName, string Contact, string Email, string RegNo)
        {
            string query = "Insert into Student(FirstName, LastName, Contact, Email, RegistrationNumber) values('@FirstName', '@LastName', '@Contact', '@Email', '@RegNo')";
            query = query.Replace("@FirstName", FirstName);
            query = query.Replace("@LastName", LastName);
            query = query.Replace("@Contact", Contact);
            query = query.Replace("@Email", Email);
            query = query.Replace("@RegNo", RegNo);
            return DBConfig.ExecuteCommand(query);
        }
    }
}
