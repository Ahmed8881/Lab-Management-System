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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DELETEST = new Button();
            UPDATEST = new Button();
            ADDBUTTON = new Button();
            RegNumber = new Label();
            Name = new Label();
            LastName = new Label();
            RegNum = new TextBox();
            FirstName = new TextBox();
            LastNames = new TextBox();
            dataGridView1 = new DataGridView();
            Email = new Label();
            PhoneNo = new Label();
            emails = new TextBox();
            Contactno = new TextBox();
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
            DELETEST.Location = new Point(1223, 537);
            DELETEST.Name = "DELETEST";
            DELETEST.Size = new Size(97, 58);
            DELETEST.TabIndex = 0;
            DELETEST.Text = "DELETE";
            DELETEST.UseVisualStyleBackColor = false;
            DELETEST.Click += DELETEST_Click;
            // 
            // UPDATEST
            // 
            UPDATEST.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UPDATEST.BackColor = SystemColors.MenuHighlight;
            UPDATEST.FlatStyle = FlatStyle.Flat;
            UPDATEST.ForeColor = SystemColors.ControlLightLight;
            UPDATEST.Location = new Point(1086, 537);
            UPDATEST.Name = "UPDATEST";
            UPDATEST.Size = new Size(97, 58);
            UPDATEST.TabIndex = 1;
            UPDATEST.Text = "UPDATE";
            UPDATEST.UseVisualStyleBackColor = false;
            UPDATEST.Click += UPDATEST_Click;
            // 
            // ADDBUTTON
            // 
            ADDBUTTON.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ADDBUTTON.BackColor = SystemColors.MenuHighlight;
            ADDBUTTON.FlatStyle = FlatStyle.Flat;
            ADDBUTTON.ForeColor = SystemColors.ControlLightLight;
            ADDBUTTON.Location = new Point(933, 537);
            ADDBUTTON.Name = "ADDBUTTON";
            ADDBUTTON.Size = new Size(99, 58);
            ADDBUTTON.TabIndex = 2;
            ADDBUTTON.Text = "ADD";
            ADDBUTTON.UseVisualStyleBackColor = false;
            ADDBUTTON.Click += ADDBUTTON_Click;
            // 
            // RegNumber
            // 
            RegNumber.AutoSize = true;
            RegNumber.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            RegNumber.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            RegNumber.Location = new Point(51, 90);
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
            // RegNum
            // 
            RegNum.Location = new Point(154, 87);
            RegNum.Name = "RegNum";
            RegNum.Size = new Size(145, 31);
            RegNum.TabIndex = 6;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(154, 153);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(145, 31);
            FirstName.TabIndex = 7;
            // 
            // LastNames
            // 
            LastNames.Location = new Point(154, 225);
            LastNames.Name = "LastNames";
            LastNames.Size = new Size(145, 31);
            LastNames.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(229, 226, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Location = new Point(390, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(961, 433);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // emails
            // 
            emails.Location = new Point(154, 285);
            emails.Name = "emails";
            emails.Size = new Size(145, 31);
            emails.TabIndex = 13;
            // 
            // Contactno
            // 
            Contactno.Location = new Point(154, 340);
            Contactno.Name = "Contactno";
            Contactno.Size = new Size(145, 31);
            Contactno.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(69, 412);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 15;
            label7.Text = "ACTIVE";
            label7.Click += label7_Click;
            // 
            // StatusCheckBox
            // 
            StatusCheckBox.AutoSize = true;
            StatusCheckBox.Location = new Point(154, 412);
            StatusCheckBox.Name = "StatusCheckBox";
            StatusCheckBox.Size = new Size(22, 21);
            StatusCheckBox.TabIndex = 16;
            StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 663);
            Controls.Add(StatusCheckBox);
            Controls.Add(label7);
            Controls.Add(Contactno);
            Controls.Add(emails);
            Controls.Add(PhoneNo);
            Controls.Add(Email);
            Controls.Add(dataGridView1);
            Controls.Add(LastNames);
            Controls.Add(FirstName);
            Controls.Add(RegNum);
            Controls.Add(LastName);
            Controls.Add(Name);
            Controls.Add(RegNumber);
            Controls.Add(ADDBUTTON);
            Controls.Add(UPDATEST);
            Controls.Add(DELETEST);
            Name = "FormStudents";
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
        private TextBox RegNum;
        private TextBox FirstName;
        private TextBox LastNames;
        private DataGridView dataGridView1;
        private Label Email;
        private Label PhoneNo;
        private TextBox emails;
        private TextBox Contactno;
        private Label label7;
        private CheckBox StatusCheckBox;
    }
}