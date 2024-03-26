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
        private bool AreAllFieldEmpty()
        {
            if (RegNum.Text == "" && FirstName.Text == "" && LastNames.Text == "" && emails.Text == "" && Contactno.Text == "")
            {
                return true;
            }
            return false;
        }
        private bool isValidEmail(string email)
        {
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }
        private bool isValidPhone(string phone)
        {
            string phonePattern = @"^03[0-4][0-9]{8}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phone, phonePattern);
        }

        private void ADDBUTTON_Click(object sender, EventArgs e)
        {
            if (AreAllFieldEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            string Reg = RegNum.Text;
            string First = FirstName.Text;
            string Last = LastNames.Text;
            if (!isValidEmail(emails.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }
            string Email = emails.Text;
            if (!isValidPhone(Contactno.Text))
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }
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
            if (AreAllFieldEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            string reg = RegNum.Text;
            string first = FirstName.Text;
            string last = LastNames.Text;
            if (!isValidPhone(Contactno.Text))
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }
            if (!isValidEmail(emails.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
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
