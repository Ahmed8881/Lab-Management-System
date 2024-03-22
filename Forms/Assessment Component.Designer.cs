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
            NameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MarksBox = new TextBox();
            AssessmentIdBox = new ComboBox();
            RubricIdBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(295, 28);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(536, 341);
            dataGridView1.TabIndex = 0;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(474, 402);
            UpdateButton.Margin = new Padding(2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(70, 30);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(593, 402);
            DeleteButton.Margin = new Padding(2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(70, 30);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(358, 402);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(70, 30);
            AddButton.TabIndex = 5;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // NameBox
            // 
            NameBox.ForeColor = Color.DarkGray;
            NameBox.Location = new Point(108, 41);
            NameBox.Margin = new Padding(2);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(143, 23);
            NameBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 158);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "RubricId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 121);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 9;
            label3.Text = " AssessmentId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 82);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "TotalMarks";
            // 
            // MarksBox
            // 
            MarksBox.ForeColor = Color.DarkGray;
            MarksBox.Location = new Point(108, 82);
            MarksBox.Margin = new Padding(2);
            MarksBox.Name = "MarksBox";
            MarksBox.Size = new Size(143, 23);
            MarksBox.TabIndex = 11;
            // 
            // AssessmentIdBox
            // 
            AssessmentIdBox.FormattingEnabled = true;
            AssessmentIdBox.Location = new Point(130, 118);
            AssessmentIdBox.Name = "AssessmentIdBox";
            AssessmentIdBox.Size = new Size(121, 23);
            AssessmentIdBox.TabIndex = 12;
            // 
            // RubricIdBox
            // 
            RubricIdBox.FormattingEnabled = true;
            RubricIdBox.Location = new Point(130, 155);
            RubricIdBox.Name = "RubricIdBox";
            RubricIdBox.Size = new Size(121, 23);
            RubricIdBox.TabIndex = 13;
            // 
            // Assessment_Component
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 566);
            Controls.Add(RubricIdBox);
            Controls.Add(AssessmentIdBox);
            Controls.Add(MarksBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameBox);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
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
        private TextBox NameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox MarksBox;
        private ComboBox AssessmentIdBox;
        private ComboBox RubricIdBox;
    }
}