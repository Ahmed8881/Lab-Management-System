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
        private void AddClo_Click(object sender, EventArgs e)
        {
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

    }
}
