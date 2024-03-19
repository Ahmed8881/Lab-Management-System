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
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 96);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Rubric ID";
            // 
            // button1
            // 
            button1.Location = new Point(430, 538);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 1;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 164);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 3;
            label2.Text = "Rubric Details";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(51, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 31);
            textBox3.TabIndex = 7;
            textBox3.Text = "Level Details";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(51, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(287, 31);
            textBox4.TabIndex = 8;
            textBox4.Text = "Measurement Details";
            // 
            // button2
            // 
            button2.Location = new Point(570, 538);
            button2.Name = "button2";
            button2.Size = new Size(91, 36);
            button2.TabIndex = 9;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(719, 538);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 10;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(421, 438);
            dataGridView1.TabIndex = 11;
            // 
            // Rubric_Level
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 695);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Rubric_Level";
            Text = "Rubric_Level";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}