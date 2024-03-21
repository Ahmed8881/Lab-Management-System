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
    public partial class Rubric_Level : Form
    {
        public Rubric_Level()
        {
            InitializeComponent();
            LoadData();
            FillLevelComboBox();
        }
        private void FillLevelComboBox()
        {
            List<int> levels = [];
            for (int i = 1; i <= 4; i++)
            {
                levels.Add(i);
            }
            LevelComboBox.DataSource = levels;
        }
        private void LoadData()
        {
            dataGridView1.DataSource = RubricLevelDL.GetRubricLevelData();
            IdComboBox.DataSource = RubricLevelDL.GetRubricId();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdComboBox.SelectedItem.ToString());
            string details = DetailsBox.Text;
            int level = int.Parse(LevelComboBox.SelectedItem.ToString());
            if (RubricLevelDL.AddRubricLevel(details, id, level))
            {
                MessageBox.Show("Rubric Level Added Successfully");
                DetailsBox.Text = "";
                LevelComboBox.SelectedIndex = 0;
                IdComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error Adding Rubric Level");
            }
            LoadData();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int rubricsId = int.Parse(IdComboBox.SelectedItem.ToString());
            string details = DetailsBox.Text;
            int level = int.Parse(LevelComboBox.SelectedItem.ToString());
            int levelId = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            if (RubricLevelDL.UpdateRubricLevel(levelId, details, rubricsId, level))
            {
                MessageBox.Show("Rubric Level Updated Successfully");
                DetailsBox.Text = "";
                LevelComboBox.SelectedIndex = 0;
                IdComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error Updating Rubric Level");
            }
            LoadData();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int levelId = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            if (RubricLevelDL.DeleteRubricLevel(levelId))
            {
                MessageBox.Show("Rubric Level Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Error Deleting Rubric Level");
            }
            LoadData();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsBox.Text = dataGridView1.CurrentRow.Cells["Details"].Value.ToString();
            IdComboBox.SelectedItem = int.Parse(dataGridView1.CurrentRow.Cells["RubricId"].Value.ToString());
            LevelComboBox.SelectedItem = int.Parse(dataGridView1.CurrentRow.Cells["MeasurementLevel"].Value.ToString());
        }
    }
}