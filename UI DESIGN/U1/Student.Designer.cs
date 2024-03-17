namespace MID
{
    partial class Student
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
            cxcx = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(185, -2);
            label1.Name = "label1";
            label1.Size = new Size(145, 47);
            label1.TabIndex = 2;
            label1.Text = "Student";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.UseMnemonic = false;
            // 
            // cxcx
            // 
            cxcx.Location = new Point(185, 76);
            cxcx.Name = "cxcx";
            cxcx.PlaceholderText = "Registration Number";
            cxcx.Size = new Size(186, 31);
            cxcx.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 126);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Last Name";
            textBox2.Size = new Size(186, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 174);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Phone Number";
            textBox3.Size = new Size(191, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(433, 76);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "First Name";
            textBox4.Size = new Size(179, 31);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(433, 126);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(179, 31);
            textBox5.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(433, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 11;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(478, 184);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 12;
            label2.Text = "Is Active";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(634, 76);
            button1.Name = "button1";
            button1.Size = new Size(260, 38);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(634, 126);
            button2.Name = "button2";
            button2.Size = new Size(260, 40);
            button2.TabIndex = 14;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(634, 176);
            button3.Name = "button3";
            button3.Size = new Size(260, 40);
            button3.TabIndex = 15;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(176, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(722, 488);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 248);
            label3.Name = "label3";
            label3.Size = new Size(724, 25);
            label3.TabIndex = 18;
            label3.Text = "StudentID        FIRST NAME         LAST NAME       EMAIL         PHONE  NUMBER       STATUS";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 751);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(cxcx);
            Controls.Add(label1);
            Name = "Student";
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox cxcx;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label3;
    }
}