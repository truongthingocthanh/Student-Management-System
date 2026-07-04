using System;
using System.Windows.Forms;
using StudentManagementSystem.DAL;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.GUI
{
    public partial class AccountForm : Form
    {
        private IAccountDAL accountDAL;
        private string loggedInUser;

        public AccountForm(string currentUser = "admin")
        {
            InitializeComponent();
            accountDAL = new AccountDALSQLite();
            this.loggedInUser = currentUser;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Lecturer");
            if (cboRole.Items.Count > 0) cboRole.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            dgvAccounts.DataSource = accountDAL.GetAll();

            if (dgvAccounts.Columns["Password"] != null)
            {
                dgvAccounts.Columns["Password"].Visible = true;
            }

            if (!string.IsNullOrEmpty(accountDAL.GetError()))
            {
                MessageBox.Show("Failed to load data: " + accountDAL.GetError(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Username and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account newAcc = new Account
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cboRole.SelectedItem?.ToString() ?? "Lecturer"
            };

            if (accountDAL.Add(newAcc))
            {
                MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to add account!\n" + accountDAL.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please select an account from the list to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account updatedAcc = new Account
            {
                Username = txtUsername.Text.Trim(),
                Role = cboRole.SelectedItem?.ToString() ?? "Lecturer"
            };

            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                updatedAcc.Password = txtPassword.Text.Trim();
            }
            else
            {
                updatedAcc.Password = "";
            }

            if (accountDAL.Update(updatedAcc))
            {
                MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to update account!\n" + accountDAL.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string targetUser = txtUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(targetUser))
            {
                MessageBox.Show("Please select an account to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (targetUser.ToLower() == loggedInUser.ToLower())
            {
                MessageBox.Show("Action denied: You cannot delete the currently logged-in account!", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete '{targetUser}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (accountDAL.Delete(targetUser))
                {
                    MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnRefresh_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete account!\n" + accountDAL.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.ReadOnly = false;
            if (cboRole.Items.Count > 0) cboRole.SelectedIndex = 0;
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Account selectedAcc = dgvAccounts.Rows[e.RowIndex].DataBoundItem as Account;
                if (selectedAcc != null)
                {
                    txtUsername.Text = selectedAcc.Username;
                    txtUsername.ReadOnly = true;
                    txtPassword.Text = selectedAcc.Password;
                    cboRole.Text = selectedAcc.Role;
                }
            }
        }
    }
}