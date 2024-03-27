namespace sample
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Contructors
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;

        }
        private void SetIdealFormSize()
        {
            // Calculate the required width and height based on the controls within the form
            int requiredWidth = CalculateIdealWidth();
            int requiredHeight = CalculateIdealHeight();

            // Set the new size of the form
            this.Size = new Size(requiredWidth, requiredHeight);
        }

        private int CalculateIdealWidth()
        {
            // Calculate the ideal width based on the controls within the form

            int totalWidth = 0;

            //  Calculate total width by summing up the widths of controls
            foreach (Control control in this.Controls)
            {
                totalWidth += control.Width + control.Margin.Left + control.Margin.Right;
            }

            // Optionally add extra width for form border and padding
            return totalWidth + SystemInformation.VerticalScrollBarWidth + SystemInformation.Border3DSize.Width * 2;
        }

        private int CalculateIdealHeight()
        {
            // Calculate the ideal height based on the controls within the form
            //  sum up the heights of all controls or determine the maximum height required
            int totalHeight = 0;

            // Example: Calculate total height by summing up the heights of controls
            foreach (Control control in this.Controls)
            {
                totalHeight += control.Height + control.Margin.Top + control.Margin.Bottom;
            }

            // Optionally add extra height for form border and title bar
            return totalHeight + SystemInformation.CaptionHeight + SystemInformation.Border3DSize.Height * 2;
        }
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void Form1_Load(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text; // we can show the title of the text of child form in the title bar

        }
        private void Student_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStudents(), sender);
        }

        private void CLO_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CLOS(), sender);
        }





        private void Result_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Results(), sender);
        }


        private void Rubric_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RUBRICS(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(65, 105, 225);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;


        }

        private void Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reports(), sender);
        }



        private void A_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ASSESSMENTS(), sender);
        }

        private void Attendence_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Attendence(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }

}
