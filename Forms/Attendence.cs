using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample.Forms
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            RegistrationBox.Items.Clear();
            StatusBox.Items.Clear();
            RegistrationBox.DataSource = AttendanceDL.GetRegNo();
            StatusBox.DataSource = AttendanceDL.GetStatuses();
        }
        private bool AreAllFieldsEmpty()
        {
            return RegistrationBox.Text == "" || StatusBox.Text == "";
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AreAllFieldsEmpty())
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            AttendanceBL attendance = new AttendanceBL(RegistrationBox.Text, StatusBox.Text, DateTime.Now);
            if (AttendanceDL.SaveAttendance(attendance))
            {
                MessageBox.Show("Attendance Saved Successfully");
            }
            else
            {
                MessageBox.Show("Failed to save attendance");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
