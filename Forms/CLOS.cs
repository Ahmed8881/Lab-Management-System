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
    public partial class CLOS : Form
    {
        public CLOS()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = CloDL.GetCloData();
            dataGridView1.DataSource = dt;
        }
        private bool AreAllFieldEmpty()
        {
            if (textBox1.Text == "")
            {
                return true;
            }
            return false;
        }
        private void AddClo_Click(object sender, EventArgs e)
        {
            if (AreAllFieldEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            string Name = textBox1.Text;
            DateTime DateCreated = DatePicker.Value;
            if (CloDL.AddClo(Name, DateCreated))
            {
                MessageBox.Show("CLO Added Successfully");
                textBox1.Text = "";
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to Add CLO");
            }
        }
        private void UpdateClo_Click(object sender, EventArgs e)
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
            string Name = textBox1.Text;
            DateTime DateUpdated = DatePicker.Value;
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            if (CloDL.UpdateClo(Id, Name, DateUpdated))
            {
                MessageBox.Show("CLO Updated Successfully");
                textBox1.Text = "";
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to Update CLO");
            }
        }
        private void DeleteClo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            if (CloDL.DeleteClo(Id))
            {
                MessageBox.Show("CLO Deleted Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to Delete CLO");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Name"].Value.ToString();
        }

    }
}
