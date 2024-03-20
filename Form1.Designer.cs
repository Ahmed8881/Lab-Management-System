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
            Assessment = new Button();
            Rubric = new Button();
            CLO = new Button();
            Student = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            panelMenu.Controls.Add(Assessment);
            panelMenu.Controls.Add(Rubric);
            panelMenu.Controls.Add(CLO);
            panelMenu.Controls.Add(Student);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 1044);
            panelMenu.TabIndex = 0;
            // 
            // A
            // 
            A.Dock = DockStyle.Top;
            A.FlatAppearance.BorderSize = 0;
            A.FlatStyle = FlatStyle.Flat;
            A.ForeColor = Color.Gainsboro;
            A.Image = (Image)resources.GetObject("A.Image");
            A.ImageAlign = ContentAlignment.MiddleLeft;
            A.Location = new Point(0, 400);
            A.Name = "A";
            A.Padding = new Padding(12, 0, 0, 0);
            A.Size = new Size(220, 64);
            A.TabIndex = 8;
            A.Text = "ASSESSMENT";
            A.TextAlign = ContentAlignment.MiddleLeft;
            A.TextImageRelation = TextImageRelation.ImageBeforeText;
            A.UseVisualStyleBackColor = true;
            A.Click += A_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Gainsboro;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 400);
            button6.Name = "button6";
            button6.Padding = new Padding(12, 0, 0, 0);
            button6.Size = new Size(220, 0);
            button6.TabIndex = 7;
            button6.Text = "  Reports";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // Attendence
            // 
            Attendence.Dock = DockStyle.Top;
            Attendence.FlatAppearance.BorderSize = 0;
            Attendence.FlatStyle = FlatStyle.Flat;
            Attendence.ForeColor = Color.Gainsboro;
            Attendence.Image = (Image)resources.GetObject("Attendence.Image");
            Attendence.ImageAlign = ContentAlignment.MiddleLeft;
            Attendence.Location = new Point(0, 336);
            Attendence.Name = "Attendence";
            Attendence.Padding = new Padding(12, 0, 0, 0);
            Attendence.Size = new Size(220, 64);
            Attendence.TabIndex = 6;
            Attendence.Text = "Attendence";
            Attendence.TextAlign = ContentAlignment.MiddleLeft;
            Attendence.TextImageRelation = TextImageRelation.ImageBeforeText;
            Attendence.UseVisualStyleBackColor = true;
            Attendence.Click += Attendence_Click;
            // 
            // Result
            // 
            Result.Dock = DockStyle.Top;
            Result.FlatAppearance.BorderSize = 0;
            Result.FlatStyle = FlatStyle.Flat;
            Result.ForeColor = Color.Gainsboro;
            Result.Image = (Image)resources.GetObject("Result.Image");
            Result.ImageAlign = ContentAlignment.MiddleLeft;
            Result.Location = new Point(0, 272);
            Result.Name = "Result";
            Result.Padding = new Padding(12, 0, 0, 0);
            Result.Size = new Size(220, 64);
            Result.TabIndex = 5;
            Result.Text = "   Result";
            Result.TextAlign = ContentAlignment.MiddleLeft;
            Result.TextImageRelation = TextImageRelation.ImageBeforeText;
            Result.UseVisualStyleBackColor = true;
            Result.Click += Result_Click;
            // 
            // Assessment
            // 
            Assessment.FlatAppearance.BorderSize = 0;
            Assessment.FlatStyle = FlatStyle.Flat;
            Assessment.ForeColor = Color.Gainsboro;
            Assessment.Image = (Image)resources.GetObject("Assessment.Image");
            Assessment.ImageAlign = ContentAlignment.MiddleLeft;
            Assessment.Location = new Point(0, 272);
            Assessment.Name = "Assessment";
            Assessment.Padding = new Padding(12, 0, 0, 0);
            Assessment.Size = new Size(220, 64);
            Assessment.TabIndex = 4;
            Assessment.Text = "Assessment";
            Assessment.TextAlign = ContentAlignment.MiddleLeft;
            Assessment.TextImageRelation = TextImageRelation.ImageBeforeText;
            Assessment.UseVisualStyleBackColor = true;
            // 
            // Rubric
            // 
            Rubric.Dock = DockStyle.Top;
            Rubric.FlatAppearance.BorderSize = 0;
            Rubric.FlatStyle = FlatStyle.Flat;
            Rubric.ForeColor = Color.Gainsboro;
            Rubric.Image = (Image)resources.GetObject("Rubric.Image");
            Rubric.ImageAlign = ContentAlignment.MiddleLeft;
            Rubric.Location = new Point(0, 208);
            Rubric.Name = "Rubric";
            Rubric.Padding = new Padding(12, 0, 0, 0);
            Rubric.Size = new Size(220, 64);
            Rubric.TabIndex = 3;
            Rubric.Text = "  Rubric";
            Rubric.TextAlign = ContentAlignment.MiddleLeft;
            Rubric.TextImageRelation = TextImageRelation.ImageBeforeText;
            Rubric.UseVisualStyleBackColor = true;
            Rubric.Click += Rubric_Click;
            // 
            // CLO
            // 
            CLO.Dock = DockStyle.Top;
            CLO.FlatAppearance.BorderSize = 0;
            CLO.FlatStyle = FlatStyle.Flat;
            CLO.ForeColor = Color.Gainsboro;
            CLO.Image = (Image)resources.GetObject("CLO.Image");
            CLO.ImageAlign = ContentAlignment.MiddleLeft;
            CLO.Location = new Point(0, 144);
            CLO.Name = "CLO";
            CLO.Padding = new Padding(12, 0, 0, 0);
            CLO.Size = new Size(220, 64);
            CLO.TabIndex = 2;
            CLO.Text = "    CLO";
            CLO.TextAlign = ContentAlignment.MiddleLeft;
            CLO.TextImageRelation = TextImageRelation.ImageBeforeText;
            CLO.UseVisualStyleBackColor = true;
            CLO.Click += CLO_Click;
            // 
            // Student
            // 
            Student.Dock = DockStyle.Top;
            Student.FlatAppearance.BorderSize = 0;
            Student.FlatStyle = FlatStyle.Flat;
            Student.ForeColor = Color.Gainsboro;
            Student.Image = (Image)resources.GetObject("Student.Image");
            Student.ImageAlign = ContentAlignment.MiddleLeft;
            Student.Location = new Point(0, 80);
            Student.Name = "Student";
            Student.Padding = new Padding(12, 0, 0, 0);
            Student.Size = new Size(220, 64);
            Student.TabIndex = 0;
            Student.Text = "Students";
            Student.TextAlign = ContentAlignment.MiddleLeft;
            Student.TextImageRelation = TextImageRelation.ImageBeforeText;
            Student.UseVisualStyleBackColor = true;
            Student.Click += Student_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.RoyalBlue;
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1091, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(471, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 37);
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
            panelDesktopPanel.Location = new Point(220, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1091, 964);
            panelDesktopPanel.TabIndex = 2;
            panelDesktopPanel.Paint += panelDesktopPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1091, 964);
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
            label3.Location = new Point(661, 593);
            label3.Name = "label3";
            label3.Size = new Size(160, 44);
            label3.TabIndex = 1;
            label3.Text = "SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(619, 538);
            label2.Name = "label2";
            label2.Size = new Size(327, 44);
            label2.TabIndex = 0;
            label2.Text = "LAB MANAGMENT ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 147);
            label1.Name = "label1";
            label1.Size = new Size(627, 60);
            label1.TabIndex = 1;
            label1.Text = "LAB MANAGMENT SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 1044);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
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
        private Button Assessment;
        private Button Rubric;
        private Button CLO;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Panel panelDesktopPanel;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button A;
        private Label label1;
    }
}
