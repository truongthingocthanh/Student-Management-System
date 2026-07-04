namespace StudentManagementSystem
{
    partial class MainForm
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
            btnManageAccounts = new Button();
            btnManageStudents = new Button();
            SuspendLayout();
            // 
            // btnManageAccounts
            // 
            btnManageAccounts.Location = new Point(518, 89);
            btnManageAccounts.Name = "btnManageAccounts";
            btnManageAccounts.Size = new Size(168, 34);
            btnManageAccounts.TabIndex = 0;
            btnManageAccounts.Text = "Manage Accounts";
            btnManageAccounts.UseVisualStyleBackColor = true;
            btnManageAccounts.Click += btnManageAccounts_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.Location = new Point(468, 188);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(163, 34);
            btnManageStudents.TabIndex = 1;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = true;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 457);
            Controls.Add(btnManageStudents);
            Controls.Add(btnManageAccounts);
            Name = "MainForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageAccounts;
        private Button btnManageStudents;
    }
}
