namespace sample.Forms
{
    partial class Attendence
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
            label2 = new Label();
            label3 = new Label();
            RegistrationBox = new ComboBox();
            StatusBox = new ComboBox();
            DatePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(119, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 0;
            label1.Text = "RegNo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(119, 133);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(119, 189);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // RegistrationBox
            // 
            RegistrationBox.FormattingEnabled = true;
            RegistrationBox.Location = new Point(239, 80);
            RegistrationBox.Margin = new Padding(3, 4, 3, 4);
            RegistrationBox.Name = "RegistrationBox";
            RegistrationBox.Size = new Size(138, 28);
            RegistrationBox.TabIndex = 3;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(239, 185);
            StatusBox.Margin = new Padding(3, 4, 3, 4);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(138, 28);
            StatusBox.TabIndex = 4;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(239, 133);
            DatePicker.Margin = new Padding(3, 4, 3, 4);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(228, 27);
            DatePicker.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.icons8_save_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(179, 254);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(198, 55);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SaveButton_Click;
            // 
            // Attendence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 397);
            Controls.Add(button1);
            Controls.Add(DatePicker);
            Controls.Add(StatusBox);
            Controls.Add(RegistrationBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Attendence";
            Text = "Attendence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox RegistrationBox;
        private ComboBox StatusBox;
        private DateTimePicker DatePicker;
        private Button button1;
    }
}