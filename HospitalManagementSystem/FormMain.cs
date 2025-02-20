using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + FormLogin.username.Replace("_", " ");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }

        private void btnMasterICD_Click(object sender, EventArgs e)
        {
            new FormMasterICD_11().Show();
            Hide ();
        }

        private void btnMasterDoctor_Click(object sender, EventArgs e)
        {
            new FormMasterDoctor().Show();
            Hide () ;
        }

        private void btnMasterPatient_Click(object sender, EventArgs e)
        {
            new FormMasterPatient().Show();
            Hide ();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            new FormNewMeeting().Show();
            Hide ();
        }

        private void btnManageMeeting_Click(object sender, EventArgs e)
        {
            new FormManageMeeting().Show();
            Hide();
        }
    }
}
