using System.Drawing.Drawing2D;

namespace MID
{
    public partial class Form1 : Form
    {
        public event EventHandler<string> SidebarItemClick;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s = new Student();
            s.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLOS c = new CLOS();
            c.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assessment a = new Assessment();
            a.Show();
        }
    }
}
