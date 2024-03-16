using System.Drawing.Drawing2D;

namespace MID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,          // The area to fill
                Color.LightBlue,               // Start color
                Color.DarkBlue,                // End color
                LinearGradientMode.Vertical); // Gradient direction (vertical in this case)

            // Fill the form's background with the gradient
            e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
