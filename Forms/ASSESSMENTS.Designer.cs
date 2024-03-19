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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(464, 324);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(194, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 31);
            textBox2.TabIndex = 4;
            textBox2.Text = "Weight";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(102, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(77, 31);
            textBox3.TabIndex = 5;
            textBox3.Text = "Marks";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.DarkGray;
            textBox4.Location = new Point(298, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(70, 31);
            textBox4.TabIndex = 6;
            textBox4.Text = "Current Date";
            // 
            // ASSESSMENTS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "ASSESSMENTS";
            Text = "ASSESSMENTS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}