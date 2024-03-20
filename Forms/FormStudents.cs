using MID.DL;
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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = StudentDL.GetStudentData();
            dataGridView1.DataSource = dt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormStudents_Load(object sender, EventArgs e)
        {

        }

        private void ADDBUTTON_Click(object sender, EventArgs e)
        {
            string Reg = RegNum.Text;
            string First = FirstName.Text;
            string Last = LastNames.Text;
            string Email = emails.Text;
            string Phone = Contactno.Text;
            bool active = StatusCheckBox.Checked;
            bool success = StudentDL.AddStudent(First, Last, Phone, Email, Reg, active);
            if (success)
            {
                MessageBox.Show("Student Added Successfully");
                RegNum.Text = "";
                FirstName.Text = "";
                LastNames.Text = "";
                emails.Text = "";
                Contactno.Text = "";
                StatusCheckBox.Checked = false;
            }
            else
            {
                MessageBox.Show("Failed to Add Student");
            }
            LoadData();
        }

        private void UPDATEST_Click(object sender, EventArgs e)
        {
            string reg = RegNum.Text;
            string first = FirstName.Text;
            string last = LastNames.Text;
            string email = emails.Text;
            string phone = Contactno.Text;
            bool active = StatusCheckBox.Checked;

            // Call the UpdateStudent method from your data layer
            bool success = StudentDL.UpdateStudent(first, last, phone, email, reg, active);

            // Check if the update was successful
            if (success)
            {
                MessageBox.Show("Student Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Update Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void DELETEST_Click(object sender, EventArgs e)
        {
            // Retrieve the registration number of the student to be deleted
            string regNo = RegNum.Text;

            // Call the DeleteStudent method from your data layer
            bool success = StudentDL.DeleteStudent(regNo);

            // Check if the deletion was successful
            if (success)
            {
                MessageBox.Show("Student Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally clear the textboxes after successful deletion
                RegNum.Text = "";
                FirstName.Text = "";
                LastNames.Text = "";
                emails.Text = "";
                Contactno.Text = "";
                StatusCheckBox.Checked = false;
            }
            else
            {
                MessageBox.Show("Failed to Delete Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve the registration number of the student from the selected row
            string regNo = dataGridView1.CurrentRow.Cells["RegistrationNumber"].Value.ToString();

            // Retrieve the first name of the student from the selected row
            string firstName = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();

            // Retrieve the last name of the student from the selected row
            string lastName = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();

            // Retrieve the email of the student from the selected row
            string email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();

            // Retrieve the contact number of the student from the selected row
            string contact = dataGridView1.CurrentRow.Cells["Contact"].Value.ToString();

            // Retrieve the status of the student from the selected row
            bool active = dataGridView1.CurrentRow.Cells["Status"].Value.ToString() == "Active";

            // Set the textboxes to the retrieved values
            RegNum.Text = regNo;
            FirstName.Text = firstName;
            LastNames.Text = lastName;
            emails.Text = email;
            Contactno.Text = contact;
            StatusCheckBox.Checked = active;
        }
    }
}
