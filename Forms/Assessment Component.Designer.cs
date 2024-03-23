namespace sample.Forms
{
    partial class Assessment_Component
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
            dataGridView1 = new DataGridView();
            UpdateButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AssessmentIdBox = new ComboBox();
            RubricIdBox = new ComboBox();
            NameBox = new TextBox();
            MarksBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 37);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(580, 455);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.Highlight;
            UpdateButton.Location = new Point(542, 536);
            UpdateButton.Margin = new Padding(2, 3, 2, 3);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(80, 40);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Highlight;
            DeleteButton.Location = new Point(678, 536);
            DeleteButton.Margin = new Padding(2, 3, 2, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(80, 40);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Highlight;
            AddButton.Location = new Point(409, 536);
            AddButton.Margin = new Padding(2, 3, 2, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(80, 40);
            AddButton.TabIndex = 5;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(32, 211);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 8;
            label2.Text = "Rubric ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(21, 161);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 9;
            label3.Text = " Assessment ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(32, 109);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 10;
            label4.Text = "TotalMarks";
            // 
            // AssessmentIdBox
            // 
            AssessmentIdBox.FormattingEnabled = true;
            AssessmentIdBox.Location = new Point(182, 165);
            AssessmentIdBox.Margin = new Padding(3, 4, 3, 4);
            AssessmentIdBox.Name = "AssessmentIdBox";
            AssessmentIdBox.Size = new Size(138, 28);
            AssessmentIdBox.TabIndex = 12;
            // 
            // RubricIdBox
            // 
            RubricIdBox.FormattingEnabled = true;
            RubricIdBox.Location = new Point(182, 215);
            RubricIdBox.Margin = new Padding(3, 4, 3, 4);
            RubricIdBox.Name = "RubricIdBox";
            RubricIdBox.Size = new Size(138, 28);
            RubricIdBox.TabIndex = 13;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(182, 60);
            NameBox.Margin = new Padding(3, 4, 3, 4);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(138, 27);
            NameBox.TabIndex = 14;
            // 
            // MarksBox
            // 
            MarksBox.Location = new Point(182, 113);
            MarksBox.Margin = new Padding(3, 4, 3, 4);
            MarksBox.Name = "MarksBox";
            MarksBox.Size = new Size(138, 27);
            MarksBox.TabIndex = 15;
            // 
            // Assessment_Component
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 755);
            Controls.Add(MarksBox);
            Controls.Add(NameBox);
            Controls.Add(RubricIdBox);
            Controls.Add(AssessmentIdBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Assessment_Component";
            Text = "Assessment_Component";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox AssessmentIdBox;
        private ComboBox RubricIdBox;
        private TextBox NameBox;
        private TextBox MarksBox;
    }
}