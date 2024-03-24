namespace sample.Forms
{
    partial class Results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            StudentBox = new ComboBox();
            label1 = new Label();
            DatePicker = new DateTimePicker();
            EvaluateButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ComponentBox = new ComboBox();
            RubricLevelBox = new ComboBox();
            AssessmentBox = new ComboBox();
            RubricDetailBox = new ComboBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            RegistrationNumber = new DataGridViewTextBoxColumn();
            Assessment = new DataGridViewTextBoxColumn();
            Component = new DataGridViewTextBoxColumn();
            Rubric = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            Marks = new DataGridViewTextBoxColumn();
            EvaluationDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StudentBox
            // 
            StudentBox.FormattingEnabled = true;
            StudentBox.Location = new Point(172, 32);
            StudentBox.Margin = new Padding(3, 2, 3, 2);
            StudentBox.Name = "StudentBox";
            StudentBox.Size = new Size(98, 23);
            StudentBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Student";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(393, 140);
            DatePicker.Margin = new Padding(3, 2, 3, 2);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(231, 23);
            DatePicker.TabIndex = 2;
            // 
            // EvaluateButton
            // 
            EvaluateButton.BackColor = SystemColors.Highlight;
            EvaluateButton.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            EvaluateButton.ForeColor = SystemColors.ControlLightLight;
            EvaluateButton.Image = (Image)resources.GetObject("EvaluateButton.Image");
            EvaluateButton.ImageAlign = ContentAlignment.MiddleLeft;
            EvaluateButton.Location = new Point(683, 98);
            EvaluateButton.Margin = new Padding(3, 2, 3, 2);
            EvaluateButton.Name = "EvaluateButton";
            EvaluateButton.Size = new Size(173, 52);
            EvaluateButton.TabIndex = 3;
            EvaluateButton.Text = "Evalute";
            EvaluateButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(39, 82);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 4;
            label2.Text = "Component";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(38, 140);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 5;
            label3.Text = "Rubric Level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(318, 30);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 6;
            label4.Text = "Assessment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(318, 84);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 7;
            label5.Text = "Rubric Detail";
            // 
            // ComponentBox
            // 
            ComponentBox.FormattingEnabled = true;
            ComponentBox.Location = new Point(172, 87);
            ComponentBox.Margin = new Padding(3, 2, 3, 2);
            ComponentBox.Name = "ComponentBox";
            ComponentBox.Size = new Size(98, 23);
            ComponentBox.TabIndex = 9;
            ComponentBox.SelectedIndexChanged += ComponentBox_SelectedIndexChanged;
            // 
            // RubricLevelBox
            // 
            RubricLevelBox.FormattingEnabled = true;
            RubricLevelBox.Location = new Point(172, 140);
            RubricLevelBox.Margin = new Padding(3, 2, 3, 2);
            RubricLevelBox.Name = "RubricLevelBox";
            RubricLevelBox.Size = new Size(98, 23);
            RubricLevelBox.TabIndex = 10;
            // 
            // AssessmentBox
            // 
            AssessmentBox.FormattingEnabled = true;
            AssessmentBox.Location = new Point(460, 33);
            AssessmentBox.Margin = new Padding(3, 2, 3, 2);
            AssessmentBox.Name = "AssessmentBox";
            AssessmentBox.Size = new Size(98, 23);
            AssessmentBox.TabIndex = 11;
            AssessmentBox.SelectedIndexChanged += AssessmentBox_SelectedIndexChanged;
            // 
            // RubricDetailBox
            // 
            RubricDetailBox.FormattingEnabled = true;
            RubricDetailBox.Location = new Point(460, 87);
            RubricDetailBox.Margin = new Padding(3, 2, 3, 2);
            RubricDetailBox.Name = "RubricDetailBox";
            RubricDetailBox.Size = new Size(98, 23);
            RubricDetailBox.TabIndex = 12;
            RubricDetailBox.SelectedIndexChanged += RubricDetailBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(318, 138);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 14;
            label7.Text = "Date";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RegistrationNumber, Assessment, Component, Rubric, Level, Marks, EvaluationDate });
            dataGridView1.Location = new Point(39, 184);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(884, 244);
            dataGridView1.TabIndex = 15;
            // 
            // RegistrationNumber
            // 
            RegistrationNumber.HeaderText = "RegistrationNumber";
            RegistrationNumber.Name = "RegistrationNumber";
            RegistrationNumber.ReadOnly = true;
            // 
            // Assessment
            // 
            Assessment.HeaderText = "Assessment";
            Assessment.Name = "Assessment";
            Assessment.ReadOnly = true;
            // 
            // Component
            // 
            Component.HeaderText = "Component";
            Component.Name = "Component";
            // 
            // Rubric
            // 
            Rubric.HeaderText = "Rubric";
            Rubric.Name = "Rubric";
            Rubric.ReadOnly = true;
            // 
            // Level
            // 
            Level.HeaderText = "Level";
            Level.Name = "Level";
            Level.ReadOnly = true;
            // 
            // Marks
            // 
            Marks.HeaderText = "Marks";
            Marks.Name = "Marks";
            Marks.ReadOnly = true;
            // 
            // EvaluationDate
            // 
            EvaluationDate.HeaderText = "EvaluationDate";
            EvaluationDate.Name = "EvaluationDate";
            EvaluationDate.ReadOnly = true;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 453);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(RubricDetailBox);
            Controls.Add(AssessmentBox);
            Controls.Add(RubricLevelBox);
            Controls.Add(ComponentBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(EvaluateButton);
            Controls.Add(DatePicker);
            Controls.Add(label1);
            Controls.Add(StudentBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Results";
            Text = "Results";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox StudentBox;
        private Label label1;
        private DateTimePicker DatePicker;
        private Button EvaluateButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox ComponentBox;
        private ComboBox RubricLevelBox;
        private ComboBox AssessmentBox;
        private ComboBox RubricDetailBox;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RegistrationNumber;
        private DataGridViewTextBoxColumn Assessment;
        private DataGridViewTextBoxColumn Component;
        private DataGridViewTextBoxColumn Rubric;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn Marks;
        private DataGridViewTextBoxColumn EvaluationDate;
    }
}