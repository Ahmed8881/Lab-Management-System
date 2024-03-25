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
            label1.Location = new Point(50, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Rubric ID";
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Highlight;
            AddButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            AddButton.ForeColor = SystemColors.ButtonHighlight;
            AddButton.Image = Properties.Resources.icons8_add_50;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(443, 536);
            AddButton.Margin = new Padding(2, 3, 2, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(174, 73);
            AddButton.TabIndex = 1;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(50, 131);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 3;
            label2.Text = "Rubric Details";
            // 
            // DetailsBox
            // 
            DetailsBox.Location = new Point(201, 135);
            DetailsBox.Margin = new Padding(2, 3, 2, 3);
            DetailsBox.Name = "DetailsBox";
            DetailsBox.Size = new Size(138, 27);
            DetailsBox.TabIndex = 6;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.Highlight;
            UpdateButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UpdateButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateButton.Image = Properties.Resources.icons8_update_done_24;
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(614, 536);
            UpdateButton.Margin = new Padding(2, 3, 2, 3);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(165, 73);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Highlight;
            DeleteButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeleteButton.ForeColor = SystemColors.ButtonHighlight;
            DeleteButton.Image = Properties.Resources.icons8_delete_48__1_;
            DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteButton.Location = new Point(757, 536);
            DeleteButton.Margin = new Padding(2, 3, 2, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(183, 73);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(395, 45);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(568, 456);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdComboBox
            // 
            IdComboBox.FormattingEnabled = true;
            IdComboBox.Location = new Point(201, 80);
            IdComboBox.Margin = new Padding(3, 4, 3, 4);
            IdComboBox.Name = "IdComboBox";
            IdComboBox.Size = new Size(138, 28);
            IdComboBox.TabIndex = 12;
            // 
            // LevelComboBox
            // 
            LevelComboBox.FormattingEnabled = true;
            LevelComboBox.Location = new Point(201, 193);
            LevelComboBox.Margin = new Padding(3, 4, 3, 4);
            LevelComboBox.Name = "LevelComboBox";
            LevelComboBox.Size = new Size(138, 28);
            LevelComboBox.TabIndex = 13;
            LevelComboBox.SelectedIndexChanged += LevelComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(50, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 14;
            label3.Text = "Rubric Level";
            // 
            // Rubric_Level
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 749);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "Rubric_Level";
            Text = "Rubric_Level";
            Load += Rubric_Level_Load;
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