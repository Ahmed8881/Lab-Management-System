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
            LoadComboBox();
            LoadData();
        }
        private void LoadComboBox()
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
        private void LoadData()
        {
            List<ResultBL> results = ResultDL.GetResults();
            dataGridView1.Rows.Clear();
            foreach (ResultBL result in results)
            {
                dataGridView1.Rows.Add(result.GetStudentRegNo(), result.GetAssessmentTitle(), result.GetComponentName(), result.GetRubricDetail(), result.GetRubricLevel(), result.GetMarks(), result.GetEvaluationDate());
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
        private bool AreFieldsEmpty()
        {
            if (StudentBox.SelectedItem == null || AssessmentBox.SelectedItem == null || ComponentBox.SelectedItem == null || RubricDetailBox.SelectedItem == null || RubricLevelBox.SelectedItem == null)
            {
                return true;
            }
            return false;
        }
        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            string studentRegNo = StudentBox.SelectedItem.ToString();
            string assessmentTitle = AssessmentBox.SelectedItem.ToString();
            string componentName = ComponentBox.SelectedItem.ToString();
            string rubricDetail = RubricDetailBox.SelectedItem.ToString();
            int rubricLevel = Convert.ToInt32(RubricLevelBox.SelectedItem);
            DateTime evaluationDate = DatePicker.Value;
            ResultBL result = new ResultBL(studentRegNo, assessmentTitle, componentName, rubricDetail, rubricLevel, evaluationDate);
            if (ResultDL.SaveResult(result))
            {
                MessageBox.Show("Result Saved Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("An Error Occurred");
            }
        }
    }
}
