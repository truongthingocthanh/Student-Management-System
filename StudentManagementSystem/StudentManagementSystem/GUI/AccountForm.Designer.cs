namespace StudentManagementSystem.GUI
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            dgvAccounts = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cboRole = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            IbUsername = new Label();
            lbPassword = new Label();
            lbRole = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AllowUserToResizeColumns = false;
            dgvAccounts.AllowUserToResizeRows = false;
            dgvAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.ColumnHeadersHeight = 34;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAccounts.Columns.AddRange(new DataGridViewColumn[] { Username, Password, Role });
            dgvAccounts.Location = new Point(0, 309);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersVisible = false;
            dgvAccounts.RowHeadersWidth = 62;
            dgvAccounts.Size = new Size(837, 185);
            dgvAccounts.TabIndex = 0;
            dgvAccounts.CellClick += dgvAccounts_CellClick;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(200, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(303, 45);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(200, 28);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(303, 45);
            txtUsername.TabIndex = 2;
            // 
            // cboRole
            // 
            cboRole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(200, 187);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(303, 46);
            cboRole.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(387, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 192, 192);
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(505, 254);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 64, 0);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(623, 254);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(741, 254);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 40);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // IbUsername
            // 
            IbUsername.AutoSize = true;
            IbUsername.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbUsername.Location = new Point(25, 26);
            IbUsername.Name = "IbUsername";
            IbUsername.Size = new Size(169, 45);
            IbUsername.TabIndex = 8;
            IbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(25, 105);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(163, 45);
            lbPassword.TabIndex = 9;
            lbPassword.Text = "Password";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRole.Location = new Point(25, 185);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(86, 45);
            lbRole.TabIndex = 10;
            lbRole.Text = "Role";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Admin_;
            pictureBox1.Location = new Point(558, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 485);
            Controls.Add(pictureBox1);
            Controls.Add(lbRole);
            Controls.Add(lbPassword);
            Controls.Add(IbUsername);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cboRole);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(dgvAccounts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountForm";
            Text = "Account Form";
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAccounts;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ComboBox cboRole;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Label IbUsername;
        private Label lbPassword;
        private Label lbRole;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
    }
}