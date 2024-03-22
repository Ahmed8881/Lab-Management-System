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
            label1.Location = new Point(104, 60);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "RegNo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 100);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 142);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // RegistrationBox
            // 
            RegistrationBox.FormattingEnabled = true;
            RegistrationBox.Location = new Point(209, 60);
            RegistrationBox.Name = "RegistrationBox";
            RegistrationBox.Size = new Size(121, 23);
            RegistrationBox.TabIndex = 3;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(209, 139);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(121, 23);
            StatusBox.TabIndex = 4;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(209, 100);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(222, 193);
            button1.Name = "button1";
            button1.Size = new Size(89, 41);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Attendence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 298);
            Controls.Add(button1);
            Controls.Add(DatePicker);
            Controls.Add(StatusBox);
            Controls.Add(RegistrationBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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