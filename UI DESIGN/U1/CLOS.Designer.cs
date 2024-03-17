namespace MID
{
    partial class CLOS
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
            button2 = new Button();
            cxcx = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(254, -4);
            label1.Name = "label1";
            label1.Size = new Size(83, 47);
            label1.TabIndex = 3;
            label1.Text = "CLO";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(474, 81);
            button1.Name = "button1";
            button1.Size = new Size(320, 45);
            button1.TabIndex = 14;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(474, 142);
            button2.Name = "button2";
            button2.Size = new Size(320, 40);
            button2.TabIndex = 15;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // cxcx
            // 
            cxcx.Location = new Point(254, 164);
            cxcx.Name = "cxcx";
            cxcx.PlaceholderText = "Date Created";
            cxcx.Size = new Size(186, 31);
            cxcx.TabIndex = 16;
            cxcx.TextChanged += cxcx_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 72);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 118);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Date Updated";
            textBox2.Size = new Size(186, 31);
            textBox2.TabIndex = 18;
            // 
            // CLOS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 678);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cxcx);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CLOS";
            Text = "CLOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox cxcx;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}