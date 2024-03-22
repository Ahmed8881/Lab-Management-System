using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample.Forms
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            RegistrationBox.Items.Clear();
            StatusBox.Items.Clear();
            RegistrationBox.DataSource = AttendanceDL.GetRegNo();
            StatusBox.DataSource = AttendanceDL.GetStatuses();
        }
    }
}
