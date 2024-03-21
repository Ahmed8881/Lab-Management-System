namespace sample.Forms
{
    partial class Rubric_Level
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
            label1 = new Label();
            AddButton = new Button();
            label2 = new Label();
            DetailsBox = new TextBox();
            UpdateButton = new Button();
            DeleteButton = new Button();
            dataGridView1 = new DataGridView();
            IdComboBox = new ComboBox();
            LevelComboBox = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(44, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Rubric ID";
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Highlight;
            AddButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            AddButton.ForeColor = SystemColors.ButtonHighlight;
            AddButton.Location = new Point(388, 402);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(101, 41);
            AddButton.TabIndex = 1;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(44, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 3;
            label2.Text = "Rubric Details";
            label2.Click += label2_Click;
            // 
            // DetailsBox
            // 
            DetailsBox.Location = new Point(176, 101);
            DetailsBox.Margin = new Padding(2);
            DetailsBox.Name = "DetailsBox";
            DetailsBox.Size = new Size(121, 23);
            DetailsBox.TabIndex = 6;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.Highlight;
            UpdateButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UpdateButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateButton.Location = new Point(537, 402);
            UpdateButton.Margin = new Padding(2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(93, 41);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Highlight;
            DeleteButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeleteButton.ForeColor = SystemColors.ButtonHighlight;
            DeleteButton.Location = new Point(662, 402);
            DeleteButton.Margin = new Padding(2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(103, 41);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 34);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(497, 342);
            dataGridView1.TabIndex = 11;
            // 
            // IdComboBox
            // 
            IdComboBox.FormattingEnabled = true;
            IdComboBox.Location = new Point(176, 60);
            IdComboBox.Name = "IdComboBox";
            IdComboBox.Size = new Size(121, 23);
            IdComboBox.TabIndex = 12;
            // 
            // LevelComboBox
            // 
            LevelComboBox.FormattingEnabled = true;
            LevelComboBox.Location = new Point(176, 145);
            LevelComboBox.Name = "LevelComboBox";
            LevelComboBox.Size = new Size(121, 23);
            LevelComboBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(44, 147);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 14;
            label3.Text = "Rubric Level";
            // 
            // Rubric_Level
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 562);
            Controls.Add(label3);
            Controls.Add(LevelComboBox);
            Controls.Add(IdComboBox);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(DetailsBox);
            Controls.Add(label2);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Rubric_Level";
            Text = "Rubric_Level";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddButton;
        private Label label2;
        private TextBox DetailsBox;
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridView dataGridView1;
        private ComboBox IdComboBox;
        private ComboBox LevelComboBox;
        private Label label3;
    }
}