using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadUserControl(new DashboardControl());

            lblPageTitle.Text = "Dashboard";
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(uc);
        }
        private void flpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashboardControl());

            lblPageTitle.Text = "Dashboard";

        }

        private void pnlFaculty_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FacultyControl());

            lblPageTitle.Text = "Faculty";

        }

        private void pnlLecturer_Click(object sender, EventArgs e)
        {
            LoadUserControl(new LecturerControl());

            lblPageTitle.Text = "Lecturer";

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
