namespace MID
{
    partial class Assessment
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 47);
            label1.TabIndex = 4;
            label1.Text = "ASSESSSMENT";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 72);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(250, 31);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(339, 119);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Name";
            textBox2.Size = new Size(95, 31);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 119);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Name";
            textBox3.Size = new Size(71, 31);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(261, 119);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Name";
            textBox4.Size = new Size(71, 31);
            textBox4.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(457, 65);
            button1.Name = "button1";
            button1.Size = new Size(320, 45);
            button1.TabIndex = 22;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(457, 119);
            button2.Name = "button2";
            button2.Size = new Size(320, 46);
            button2.TabIndex = 23;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            // 
            // Assessment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Assessment";
            Text = "Assessment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}