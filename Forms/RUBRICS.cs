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
    public partial class RUBRICS : Form
    {
        public RUBRICS()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            RUBRICSGRID.DataSource = RubricDL.GetRubricData();
            FillComboBox();
        }
        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            List<int> ids = RubricDL.GetCLOIds();
            foreach (int id in ids)
            {
                comboBox1.Items.Add(id);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RUBRIC_LEVEL_Click(object sender, EventArgs e)
        {
            Rubric_Level rubricLevel = new Rubric_Level();
            rubricLevel.Show();
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            string details = textBox1.Text;
            int cloId = int.Parse(comboBox1.SelectedItem.ToString());
            if (RubricDL.AddRubric(details, cloId))
            {
                MessageBox.Show("Rubric Added Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error Adding Rubric");
            }
        }
        private void UPDATECLO_Click(object sender, EventArgs e)
        {
            string details = textBox1.Text;
            int cloId = int.Parse(comboBox1.SelectedItem.ToString());
            int id = int.Parse(RUBRICSGRID.CurrentRow.Cells["Id"].Value.ToString());
            if (RubricDL.UpdateRubric(id, details, cloId))
            {
                MessageBox.Show("Rubric Updated Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error Updating Rubric");
            }
        }
        private void DELETECLO_Click(object sender, EventArgs e)
        {
            int id = int.Parse(RUBRICSGRID.CurrentRow.Cells["Id"].Value.ToString());
            if (RubricDL.DeleteRubric(id))
            {
                MessageBox.Show("Rubric Deleted Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error Deleting Rubric");
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.RUBRICSGRID.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Details"].Value.ToString();
            comboBox1.SelectedItem = row.Cells["CloId"].Value;
        }
    }
}
