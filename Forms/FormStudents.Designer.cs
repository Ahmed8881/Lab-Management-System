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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            DELETEST.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DELETEST.ForeColor = SystemColors.ControlLightLight;
            DELETEST.Image = (Image)resources.GetObject("DELETEST.Image");
            DELETEST.ImageAlign = ContentAlignment.MiddleLeft;
            DELETEST.Location = new Point(803, 377);
            DELETEST.Margin = new Padding(2, 3, 2, 3);
            DELETEST.Name = "DELETEST";
            DELETEST.Size = new Size(169, 62);
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
            UPDATEST.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UPDATEST.ForeColor = SystemColors.ControlLightLight;
            UPDATEST.Image = Properties.Resources.icons8_update_done_24;
            UPDATEST.ImageAlign = ContentAlignment.MiddleLeft;
            UPDATEST.Location = new Point(613, 377);
            UPDATEST.Margin = new Padding(2, 3, 2, 3);
            UPDATEST.Name = "UPDATEST";
            UPDATEST.Size = new Size(149, 62);
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
            ADDBUTTON.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ADDBUTTON.ForeColor = SystemColors.ControlLightLight;
            ADDBUTTON.Image = (Image)resources.GetObject("ADDBUTTON.Image");
            ADDBUTTON.ImageAlign = ContentAlignment.MiddleLeft;
            ADDBUTTON.Location = new Point(451, 377);
            ADDBUTTON.Margin = new Padding(2, 3, 2, 3);
            ADDBUTTON.Name = "ADDBUTTON";
            ADDBUTTON.Size = new Size(132, 62);
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
            RegNumber.Location = new Point(41, 72);
            RegNumber.Margin = new Padding(2, 0, 2, 0);
            RegNumber.Name = "RegNumber";
            RegNumber.Size = new Size(83, 23);
            RegNumber.TabIndex = 3;
            RegNumber.Text = "Reg Num";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            Name.Location = new Point(33, 125);
            Name.Margin = new Padding(2, 0, 2, 0);
            Name.Name = "Name";
            Name.Size = new Size(93, 23);
            Name.TabIndex = 4;
            Name.Text = "First Name";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            LastName.Location = new Point(34, 180);
            LastName.Margin = new Padding(2, 0, 2, 0);
            LastName.Name = "LastName";
            LastName.Size = new Size(91, 23);
            LastName.TabIndex = 5;
            LastName.Text = "Last Name";
            // 
            // RegNum
            // 
            RegNum.Location = new Point(128, 71);
            RegNum.Margin = new Padding(2, 3, 2, 3);
            RegNum.Name = "RegNum";
            RegNum.Size = new Size(117, 27);
            RegNum.TabIndex = 6;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(123, 123);
            FirstName.Margin = new Padding(2, 3, 2, 3);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(117, 27);
            FirstName.TabIndex = 7;
            // 
            // LastNames
            // 
            LastNames.Location = new Point(123, 180);
            LastNames.Margin = new Padding(2, 3, 2, 3);
            LastNames.Name = "LastNames";
            LastNames.Size = new Size(117, 27);
            LastNames.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(229, 226, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Location = new Point(312, 61);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(769, 291);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            Email.Location = new Point(55, 228);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(51, 23);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // PhoneNo
            // 
            PhoneNo.AutoSize = true;
            PhoneNo.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            PhoneNo.Location = new Point(24, 272);
            PhoneNo.Margin = new Padding(2, 0, 2, 0);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(99, 23);
            PhoneNo.TabIndex = 12;
            PhoneNo.Text = "Phone num";
            // 
            // emails
            // 
            emails.Location = new Point(123, 228);
            emails.Margin = new Padding(2, 3, 2, 3);
            emails.Name = "emails";
            emails.Size = new Size(117, 27);
            emails.TabIndex = 13;
            // 
            // Contactno
            // 
            Contactno.Location = new Point(123, 272);
            Contactno.Margin = new Padding(2, 3, 2, 3);
            Contactno.Name = "Contactno";
            Contactno.Size = new Size(117, 27);
            Contactno.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(55, 329);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 15;
            label7.Text = "ACTIVE";
            label7.Click += label7_Click;
            // 
            // StatusCheckBox
            // 
            StatusCheckBox.AutoSize = true;
            StatusCheckBox.Location = new Point(123, 329);
            StatusCheckBox.Margin = new Padding(2, 3, 2, 3);
            StatusCheckBox.Name = "StatusCheckBox";
            StatusCheckBox.Size = new Size(18, 17);
            StatusCheckBox.TabIndex = 16;
            StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 531);
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
            Margin = new Padding(2, 3, 2, 3);
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