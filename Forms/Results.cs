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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            List<string> AssessmentTitles = ResultDL.GetAssessmentTitle();
            List<string> StudentRegNos = ResultDL.GetStudentRegNos();
            StudentBox.Items.Clear();
            AssessmentBox.Items.Clear();
            foreach (string title in AssessmentTitles)
            {
                AssessmentBox.Items.Add(title);
            }
            foreach (string regNo in StudentRegNos)
            {
                StudentBox.Items.Add(regNo);
            }
        }
        // When An Assessment is Selected from the ComboBox Load its Components in the Component ComboBox
        private void AssessmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = AssessmentBox.SelectedItem.ToString();
            List<string> components = ResultDL.GetAssessmentComponentNames(title);
            ComponentBox.Items.Clear();
            foreach (string component in components)
            {
                ComponentBox.Items.Add(component);
            }
        }
        // When A Component is Selected from the ComboBox Load its Rubric Details in the Rubric Detail ComboBox
        private void ComponentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string componentName = ComponentBox.SelectedItem.ToString();
            List<string> rubricDetails = ResultDL.GetRubricDetails(componentName);
            RubricDetailBox.Items.Clear();
            foreach (string detail in rubricDetails)
            {
                RubricDetailBox.Items.Add(detail);
            }
        }
        // When A Rubric Detail is Selected from the ComboBox Load its Measurement Levels in the Rubric Level ComboBox
        private void RubricDetailBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string detail = RubricDetailBox.SelectedItem.ToString();
            List<int> levels = ResultDL.GetRubricMeasurementLevel(detail);
            RubricLevelBox.Items.Clear();
            foreach (int level in levels)
            {
                RubricLevelBox.Items.Add(level);
            }
        }
    }
}
