namespace sample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            A = new Button();
            button6 = new Button();
            Attendence = new Button();
            Result = new Button();
            Rubric = new Button();
            CLO = new Button();
            Student = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(A);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(Attendence);
            panelMenu.Controls.Add(Result);
            panelMenu.Controls.Add(Rubric);
            panelMenu.Controls.Add(CLO);
            panelMenu.Controls.Add(Student);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(196, 835);
            panelMenu.TabIndex = 0;
  
            A.BackColor = Color.FromArgb(51, 51, 76);
            A.Dock = DockStyle.Top;
            A.FlatAppearance.BorderSize = 0;
            A.FlatStyle = FlatStyle.Flat;
            A.ForeColor = Color.Gainsboro;
            A.Image = (Image)resources.GetObject("A.Image");
            A.ImageAlign = ContentAlignment.MiddleLeft;
            A.Location = new Point(0, 456);
            A.Margin = new Padding(2);
            A.Name = "A";
            A.Padding = new Padding(10, 0, 0, 0);
            A.Size = new Size(196, 87);
            A.TabIndex = 9;
            A.Text = "ASSESSMENT";
            A.TextAlign = ContentAlignment.MiddleLeft;
            A.TextImageRelation = TextImageRelation.ImageBeforeText;
            A.UseVisualStyleBackColor = false;
            A.Click += A_Click_1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Gainsboro;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 456);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(196, 0);
            button6.TabIndex = 7;
            button6.Text = "  Reports";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // Attendence
            // 
            Attendence.BackColor = Color.FromArgb(51, 51, 76);
            Attendence.Dock = DockStyle.Top;
            Attendence.FlatAppearance.BorderSize = 0;
            Attendence.FlatStyle = FlatStyle.Flat;
            Attendence.ForeColor = Color.Gainsboro;
            Attendence.Image = (Image)resources.GetObject("Attendence.Image");
            Attendence.ImageAlign = ContentAlignment.MiddleLeft;
            Attendence.Location = new Point(0, 391);
            Attendence.Margin = new Padding(2);
            Attendence.Name = "Attendence";
            Attendence.Padding = new Padding(10, 0, 0, 0);
            Attendence.Size = new Size(196, 65);
            Attendence.TabIndex = 6;
            Attendence.Text = "Attendence";
            Attendence.TextAlign = ContentAlignment.MiddleLeft;
            Attendence.TextImageRelation = TextImageRelation.ImageBeforeText;
            Attendence.UseVisualStyleBackColor = false;
            Attendence.Click += Attendence_Click;
            // 
            // Result
            // 
            Result.BackColor = Color.FromArgb(51, 51, 76);
            Result.Dock = DockStyle.Top;
            Result.FlatAppearance.BorderSize = 0;
            Result.FlatStyle = FlatStyle.Flat;
            Result.ForeColor = Color.Gainsboro;
            Result.Image = (Image)resources.GetObject("Result.Image");
            Result.ImageAlign = ContentAlignment.MiddleLeft;
            Result.Location = new Point(0, 316);
            Result.Margin = new Padding(2);
            Result.Name = "Result";
            Result.Padding = new Padding(10, 0, 0, 0);
            Result.Size = new Size(196, 75);
            Result.TabIndex = 5;
            Result.Text = "   Result";
            Result.TextAlign = ContentAlignment.MiddleLeft;
            Result.TextImageRelation = TextImageRelation.ImageBeforeText;
            Result.UseVisualStyleBackColor = false;
            Result.Click += Result_Click;
            // 
            // Rubric
            // 
            Rubric.BackColor = Color.FromArgb(51, 51, 76);
            Rubric.Dock = DockStyle.Top;
            Rubric.FlatAppearance.BorderSize = 0;
            Rubric.FlatStyle = FlatStyle.Flat;
            Rubric.ForeColor = Color.Gainsboro;
            Rubric.Image = (Image)resources.GetObject("Rubric.Image");
            Rubric.ImageAlign = ContentAlignment.MiddleLeft;
            Rubric.Location = new Point(0, 232);
            Rubric.Margin = new Padding(2);
            Rubric.Name = "Rubric";
            Rubric.Padding = new Padding(10, 0, 0, 0);
            Rubric.Size = new Size(196, 84);
            Rubric.TabIndex = 3;
            Rubric.Text = "  Rubric";
            Rubric.TextAlign = ContentAlignment.MiddleLeft;
            Rubric.TextImageRelation = TextImageRelation.ImageBeforeText;
            Rubric.UseVisualStyleBackColor = false;
            Rubric.Click += Rubric_Click;
            // 
            // CLO
            // 
            CLO.BackColor = Color.FromArgb(51, 51, 76);
            CLO.Dock = DockStyle.Top;
            CLO.FlatAppearance.BorderSize = 0;
            CLO.FlatStyle = FlatStyle.Flat;
            CLO.ForeColor = Color.Gainsboro;
            CLO.Image = (Image)resources.GetObject("CLO.Image");
            CLO.ImageAlign = ContentAlignment.MiddleLeft;
            CLO.Location = new Point(0, 162);
            CLO.Margin = new Padding(2);
            CLO.Name = "CLO";
            CLO.Padding = new Padding(10, 0, 0, 0);
            CLO.Size = new Size(196, 70);
            CLO.TabIndex = 2;
            CLO.Text = "    CLO";
            CLO.TextAlign = ContentAlignment.MiddleLeft;
            CLO.TextImageRelation = TextImageRelation.ImageBeforeText;
            CLO.UseVisualStyleBackColor = false;
            CLO.Click += CLO_Click;
            // 
            // Student
            // 
            Student.BackColor = Color.FromArgb(51, 51, 76);
            Student.Dock = DockStyle.Top;
            Student.FlatAppearance.BorderSize = 0;
            Student.FlatStyle = FlatStyle.Flat;
            Student.ForeColor = Color.Gainsboro;
            Student.Image = (Image)resources.GetObject("Student.Image");
            Student.ImageAlign = ContentAlignment.MiddleLeft;
            Student.Location = new Point(0, 64);
            Student.Margin = new Padding(2);
            Student.Name = "Student";
            Student.Padding = new Padding(10, 0, 0, 0);
            Student.Size = new Size(196, 98);
            Student.TabIndex = 0;
            Student.Text = "Students";
            Student.TextAlign = ContentAlignment.MiddleLeft;
            Student.TextImageRelation = TextImageRelation.ImageBeforeText;
            Student.UseVisualStyleBackColor = false;
            Student.Click += Student_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(196, 64);
            panelLogo.TabIndex = 1;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.RoyalBlue;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(196, 0);
            panelTitleBar.Margin = new Padding(2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(853, 95);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(367, 33);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Controls.Add(label1);
            panelDesktopPanel.Controls.Add(pictureBox1);
            panelDesktopPanel.Controls.Add(label3);
            panelDesktopPanel.Controls.Add(label2);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(196, 95);
            panelDesktopPanel.Margin = new Padding(2);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(853, 740);
            panelDesktopPanel.TabIndex = 2;
            panelDesktopPanel.Paint += panelDesktopPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(523, 50);
            label1.TabIndex = 1;
            label1.Text = "LAB MANAGMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 740);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(529, 474);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 37);
            label3.TabIndex = 1;
            label3.Text = "SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(495, 430);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 0;
            label2.Text = "LAB MANAGMENT ";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 835);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button Student;
        private Button button6;
        private Button Attendence;
        private Button Result;
        private Button Rubric;
        private Button CLO;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button A;
    }
}
