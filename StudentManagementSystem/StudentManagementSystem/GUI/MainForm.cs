using System;
using System.Windows.Forms;
using StudentManagementSystem.GUI; // DÒNG CỨU TINH GIÚP NHẬN DIỆN FORM

namespace StudentManagementSystem
{
    public partial class MainForm : Form
    {
        private string loggedInUsername;

        public MainForm(string username = "admin")
        {
            InitializeComponent();
            this.loggedInUsername = username;

            this.Text = "Main Dashboard - Logged in as: " + loggedInUsername;
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            AccountForm accForm = new AccountForm(loggedInUsername);
            accForm.ShowDialog();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            StudentForm stdForm = new StudentForm();
            stdForm.ShowDialog();
        }
    }
}