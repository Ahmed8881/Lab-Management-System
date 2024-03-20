namespace sample.Forms
{
    partial class ASSESSMENTS
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
            TitleBox = new TextBox();
            AddButton = new Button();
            label2 = new Label();
            WeightBox = new TextBox();
            MarksBox = new TextBox();
            DeleteButton = new Button();
            UpdateButton = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(158, 59);
            TitleBox.Margin = new Padding(2, 3, 2, 3);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(263, 27);
            TitleBox.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Highlight;
            AddButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            AddButton.ForeColor = SystemColors.ButtonHighlight;
            AddButton.Location = new Point(538, 459);
            AddButton.Margin = new Padding(2, 3, 2, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(132, 48);
            AddButton.TabIndex = 2;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // WeightBox
            // 
            WeightBox.ForeColor = Color.Black;
            WeightBox.Location = new Point(158, 183);
            WeightBox.Margin = new Padding(2, 3, 2, 3);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(263, 27);
            WeightBox.TabIndex = 4;
            // 
            // MarksBox
            // 
            MarksBox.ForeColor = Color.Black;
            MarksBox.Location = new Point(158, 119);
            MarksBox.Margin = new Padding(2, 3, 2, 3);
            MarksBox.Name = "MarksBox";
            MarksBox.Size = new Size(263, 27);
            MarksBox.TabIndex = 5;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Highlight;
            DeleteButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DeleteButton.ForeColor = SystemColors.ButtonHighlight;
            DeleteButton.Location = new Point(911, 459);
            DeleteButton.Margin = new Padding(2, 3, 2, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 48);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "DELETE\r\n";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.Highlight;
            UpdateButton.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UpdateButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateButton.Location = new Point(705, 459);
            UpdateButton.Margin = new Padding(2, 3, 2, 3);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(121, 48);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "UPDATE\r\n";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(519, 23);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(539, 405);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(43, 345);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(362, 51);
            button4.TabIndex = 10;
            button4.Text = "Go To Assessment Comp\r\n Page\r\n";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 115);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 11;
            label1.Text = "Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 179);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 12;
            label3.Text = "Weightage";
            // 
            // ASSESSMENTS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1112, 715);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(MarksBox);
            Controls.Add(WeightBox);
            Controls.Add(label2);
            Controls.Add(AddButton);
            Controls.Add(TitleBox);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ASSESSMENTS";
            Text = "ASSESSMENTS";
            Load += ASSESSMENTS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TitleBox;
        private Button AddButton;
        private Label label2;
        private TextBox WeightBox;
        private TextBox MarksBox;
        private Button DeleteButton;
        private Button UpdateButton;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label1;
        private Label label3;
    }
}