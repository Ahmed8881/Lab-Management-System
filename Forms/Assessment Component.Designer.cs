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
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(421, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(477, 463);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(55, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Rubric ID";
            // 
            // button2
            // 
            button2.Location = new Point(604, 553);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 3;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(763, 553);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 4;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(458, 553);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 5;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(220, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 31);
            textBox2.TabIndex = 6;
            textBox2.Text = "Rubric Detail";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(55, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 31);
            textBox3.TabIndex = 7;
            textBox3.Text = "Assessment ID";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.DarkGray;
            textBox4.Location = new Point(220, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 31);
            textBox4.TabIndex = 8;
            textBox4.Text = "Assessment Title";
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.DarkGray;
            textBox5.Location = new Point(55, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 31);
            textBox5.TabIndex = 9;
            textBox5.Text = "Name";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.ForeColor = Color.DarkGray;
            textBox6.Location = new Point(220, 251);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(137, 31);
            textBox6.TabIndex = 10;
            textBox6.Text = "Total Marks";
            // 
            // Assessment_Component
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 682);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Assessment_Component";
            Text = "Assessment_Component";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}