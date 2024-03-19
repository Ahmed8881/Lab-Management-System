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
            label4 = new Label();
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
            DELETEST.Location = new Point(856, 322);
            DELETEST.Margin = new Padding(2, 2, 2, 2);
            DELETEST.Name = "DELETEST";
            DELETEST.Size = new Size(68, 35);
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
            UPDATEST.Location = new Point(760, 322);
            UPDATEST.Margin = new Padding(2, 2, 2, 2);
            UPDATEST.Name = "UPDATEST";
            UPDATEST.Size = new Size(68, 35);
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
            ADDBUTTON.Location = new Point(653, 322);
            ADDBUTTON.Margin = new Padding(2, 2, 2, 2);
            ADDBUTTON.Name = "ADDBUTTON";
            ADDBUTTON.Size = new Size(69, 35);
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
            RegNumber.Location = new Point(36, 54);
            RegNumber.Margin = new Padding(2, 0, 2, 0);
            RegNumber.Name = "RegNumber";
            RegNumber.Size = new Size(68, 19);
            RegNumber.TabIndex = 3;
            RegNumber.Text = "Reg Num";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            Name.Location = new Point(29, 94);
            Name.Margin = new Padding(2, 0, 2, 0);
            Name.Name = "Name";
            Name.Size = new Size(77, 19);
            Name.TabIndex = 4;
            Name.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            LastName.Location = new Point(30, 135);
            LastName.Margin = new Padding(2, 0, 2, 0);
            LastName.Name = "LastName";
            LastName.Size = new Size(75, 19);
            LastName.TabIndex = 5;
            LastName.Text = "Last Name";
            // 
            // RegNum
            // 
            RegNum.Location = new Point(108, 52);
            RegNum.Margin = new Padding(2, 2, 2, 2);
            RegNum.Name = "RegNum";
            RegNum.Size = new Size(103, 23);
            RegNum.TabIndex = 6;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(108, 92);
            FirstName.Margin = new Padding(2, 2, 2, 2);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(103, 23);
            FirstName.TabIndex = 7;
            // 
            // LastNames
            // 
            LastNames.Location = new Point(108, 135);
            LastNames.Margin = new Padding(2, 2, 2, 2);
            LastNames.Name = "LastNames";
            LastNames.Size = new Size(103, 23);
            LastNames.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(295, 18);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 9;
            label4.Text = "label4";
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
            dataGridView1.Location = new Point(273, 52);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(673, 260);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            Email.Location = new Point(48, 171);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(43, 19);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // PhoneNo
            // 
            PhoneNo.AutoSize = true;
            PhoneNo.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            PhoneNo.Location = new Point(21, 204);
            PhoneNo.Margin = new Padding(2, 0, 2, 0);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(80, 19);
            PhoneNo.TabIndex = 12;
            PhoneNo.Text = "Phone num";
            // 
            // emails
            // 
            emails.Location = new Point(108, 171);
            emails.Margin = new Padding(2, 2, 2, 2);
            emails.Name = "emails";
            emails.Size = new Size(103, 23);
            emails.TabIndex = 13;
            // 
            // Contactno
            // 
            Contactno.Location = new Point(108, 204);
            Contactno.Margin = new Padding(2, 2, 2, 2);
            Contactno.Name = "Contactno";
            Contactno.Size = new Size(103, 23);
            Contactno.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(48, 247);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 15;
            label7.Text = "ACTIVE";
            label7.Click += label7_Click;
            // 
            // StatusCheckBox
            // 
            StatusCheckBox.AutoSize = true;
            StatusCheckBox.Location = new Point(108, 247);
            StatusCheckBox.Margin = new Padding(2, 2, 2, 2);
            StatusCheckBox.Name = "StatusCheckBox";
            StatusCheckBox.Size = new Size(15, 14);
            StatusCheckBox.TabIndex = 16;
            StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 398);
            Controls.Add(StatusCheckBox);
            Controls.Add(label7);
            Controls.Add(Contactno);
            Controls.Add(emails);
            Controls.Add(PhoneNo);
            Controls.Add(Email);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(LastNames);
            Controls.Add(FirstName);
            Controls.Add(RegNum);
            Controls.Add(LastName);
            Controls.Add(Name);
            Controls.Add(RegNumber);
            Controls.Add(ADDBUTTON);
            Controls.Add(UPDATEST);
            Controls.Add(DELETEST);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label label4;
        private DataGridView dataGridView1;
        private Label Email;
        private Label PhoneNo;
        private TextBox emails;
        private TextBox Contactno;
        private Label label7;
        private CheckBox StatusCheckBox;
    }
}