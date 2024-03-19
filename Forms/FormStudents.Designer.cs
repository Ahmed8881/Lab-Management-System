namespace sample.Forms
{
    partial class FormStudents
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
            DELETEST = new Button();
            UPDATEST = new Button();
            ADDBUTTON = new Button();
            RegNumber = new Label();
            Name = new Label();
            LastName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Email = new Label();
            PhoneNo = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            StatusCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DELETEST
            // 
            DELETEST.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DELETEST.BackColor = SystemColors.MenuHighlight;
            DELETEST.FlatStyle = FlatStyle.Flat;
            DELETEST.ForeColor = SystemColors.ControlLightLight;
            DELETEST.Location = new Point(725, 537);
            DELETEST.Name = "DELETEST";
            DELETEST.Size = new Size(97, 58);
            DELETEST.TabIndex = 0;
            DELETEST.Text = "DELETE";
            DELETEST.UseVisualStyleBackColor = false;
            // 
            // UPDATEST
            // 
            UPDATEST.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UPDATEST.BackColor = SystemColors.MenuHighlight;
            UPDATEST.FlatStyle = FlatStyle.Flat;
            UPDATEST.ForeColor = SystemColors.ControlLightLight;
            UPDATEST.Location = new Point(588, 537);
            UPDATEST.Name = "UPDATEST";
            UPDATEST.Size = new Size(97, 58);
            UPDATEST.TabIndex = 1;
            UPDATEST.Text = "UPDATE";
            UPDATEST.UseVisualStyleBackColor = false;
            // 
            // ADDBUTTON
            // 
            ADDBUTTON.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ADDBUTTON.BackColor = SystemColors.MenuHighlight;
            ADDBUTTON.FlatStyle = FlatStyle.Flat;
            ADDBUTTON.ForeColor = SystemColors.ControlLightLight;
            ADDBUTTON.Location = new Point(435, 537);
            ADDBUTTON.Name = "ADDBUTTON";
            ADDBUTTON.Size = new Size(98, 58);
            ADDBUTTON.TabIndex = 2;
            ADDBUTTON.Text = "ADD";
            ADDBUTTON.UseVisualStyleBackColor = false;
            // 
            // RegNumber
            // 
            RegNumber.AutoSize = true;
            RegNumber.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            RegNumber.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            RegNumber.Location = new Point(52, 90);
            RegNumber.Name = "RegNumber";
            RegNumber.Size = new Size(98, 28);
            RegNumber.TabIndex = 3;
            RegNumber.Text = "Reg Num";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            Name.Location = new Point(41, 157);
            Name.Name = "Name";
            Name.Size = new Size(110, 28);
            Name.TabIndex = 4;
            Name.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            LastName.Location = new Point(43, 225);
            LastName.Name = "LastName";
            LastName.Size = new Size(108, 28);
            LastName.TabIndex = 5;
            LastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 31);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(422, 30);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(464, 433);
            dataGridView1.TabIndex = 10;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            Email.Location = new Point(69, 285);
            Email.Name = "Email";
            Email.Size = new Size(60, 28);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // PhoneNo
            // 
            PhoneNo.AutoSize = true;
            PhoneNo.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            PhoneNo.Location = new Point(30, 340);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(119, 28);
            PhoneNo.TabIndex = 12;
            PhoneNo.Text = "Phone num";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 31);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 31);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(69, 411);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 15;
            label7.Text = "ACTIVE";
            label7.Click += label7_Click;
            // 
            // StatusCheckBox
            // 
            StatusCheckBox.AutoSize = true;
            StatusCheckBox.Location = new Point(155, 411);
            StatusCheckBox.Name = "StatusCheckBox";
            StatusCheckBox.Size = new Size(22, 21);
            StatusCheckBox.TabIndex = 16;
            StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 663);
            Controls.Add(StatusCheckBox);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(PhoneNo);
            Controls.Add(Email);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LastName);
            Controls.Add(Name);
            Controls.Add(RegNumber);
            Controls.Add(ADDBUTTON);
            Controls.Add(UPDATEST);
            Controls.Add(DELETEST);
            Text = "Students";
            Load += FormStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DELETEST;
        private Button UPDATEST;
        private Button ADDBUTTON;
        private Label RegNumber;
        private Label Name;
        private Label LastName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label Email;
        private Label PhoneNo;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private CheckBox StatusCheckBox;
    }
}