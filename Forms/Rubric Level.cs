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
        private bool AreAllFieldEmpty()
        {
            if (DetailsBox.Text == "" && LevelComboBox.SelectedIndex == 0 && IdComboBox.SelectedIndex == 0)
            {
                return true;
            }
            return false;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AreAllFieldEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Row First");
                return;
            }
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

        private void Rubric_Level_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}