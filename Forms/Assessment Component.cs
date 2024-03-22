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
    public partial class Assessment_Component : Form
    {
        public Assessment_Component()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = AssessmentComponentDL.GetData();
            RubricIdBox.DataSource = AssessmentComponentDL.GetRubricIds();
            AssessmentIdBox.DataSource = AssessmentComponentDL.GetAssessmentIds();
        }
        private void ClearFields()
        {
            NameBox.Text = "";
            MarksBox.Text = "";
            RubricIdBox.SelectedIndex = 0;
            AssessmentIdBox.SelectedIndex = 0;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            int TotalMarks = int.Parse(MarksBox.Text);
            int RubricId = int.Parse(RubricIdBox.SelectedItem.ToString());
            int AssessmentId = int.Parse(AssessmentIdBox.SelectedItem.ToString());
            if (AssessmentComponentDL.AddData(name, RubricId, AssessmentId, TotalMarks))
            {
                MessageBox.Show("Data Added Successfully");
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Error in Adding Data");
            }
            LoadData();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string name = NameBox.Text;
            int TotalMarks = int.Parse(MarksBox.Text);
            int RubricId = int.Parse(RubricIdBox.SelectedItem.ToString());
            int AssessmentId = int.Parse(AssessmentIdBox.SelectedItem.ToString());
            if (AssessmentComponentDL.UpdateData(Id, name, RubricId, AssessmentId, TotalMarks))
            {
                MessageBox.Show("Data Updated Successfully");
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Error in Updating Data");
            }
            LoadData();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (AssessmentComponentDL.DeleteData(Id))
            {
                MessageBox.Show("Data Deleted Successfully");
                ClearFields();
                LoadData();
            }
            else
            {
                MessageBox.Show("Error in Deleting Data");
            }
            LoadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameBox.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            MarksBox.Text = dataGridView1.CurrentRow.Cells["TotalMarks"].Value.ToString();
            RubricIdBox.SelectedItem = dataGridView1.CurrentRow.Cells["RubricId"].Value;
            AssessmentIdBox.SelectedItem = dataGridView1.CurrentRow.Cells["AssessmentId"].Value;
        }
    }
}
