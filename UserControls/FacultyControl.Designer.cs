namespace WindowsFormsApp1
{
    partial class FacultyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpFacultyInformation = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFacultyId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFacultyId = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpFacultyList = new System.Windows.Forms.GroupBox();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.clnFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFacultyInformation.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpFacultyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFacultyInformation
            // 
            this.grpFacultyInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFacultyInformation.Controls.Add(this.btnClear);
            this.grpFacultyInformation.Controls.Add(this.txtFacultyName);
            this.grpFacultyInformation.Controls.Add(this.btnCancel);
            this.grpFacultyInformation.Controls.Add(this.txtFacultyId);
            this.grpFacultyInformation.Controls.Add(this.btnSave);
            this.grpFacultyInformation.Controls.Add(this.lblFacultyName);
            this.grpFacultyInformation.Controls.Add(this.btnDelete);
            this.grpFacultyInformation.Controls.Add(this.lblFacultyId);
            this.grpFacultyInformation.Controls.Add(this.btnEdit);
            this.grpFacultyInformation.Controls.Add(this.btnAdd);
            this.grpFacultyInformation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFacultyInformation.Location = new System.Drawing.Point(41, 44);
            this.grpFacultyInformation.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpFacultyInformation.Name = "grpFacultyInformation";
            this.grpFacultyInformation.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpFacultyInformation.Size = new System.Drawing.Size(1140, 248);
            this.grpFacultyInformation.TabIndex = 0;
            this.grpFacultyInformation.TabStop = false;
            this.grpFacultyInformation.Text = "Faculty Information";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(941, 164);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(216, 94);
            this.txtFacultyName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(433, 34);
            this.txtFacultyName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(778, 164);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.Location = new System.Drawing.Point(216, 46);
            this.txtFacultyId.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.Size = new System.Drawing.Size(342, 34);
            this.txtFacultyId.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(621, 164);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Location = new System.Drawing.Point(43, 97);
            this.lblFacultyName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(141, 28);
            this.lblFacultyName.TabIndex = 1;
            this.lblFacultyName.Text = "Faculty Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(463, 164);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFacultyId
            // 
            this.lblFacultyId.AutoSize = true;
            this.lblFacultyId.Location = new System.Drawing.Point(43, 49);
            this.lblFacultyId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFacultyId.Name = "lblFacultyId";
            this.lblFacultyId.Size = new System.Drawing.Size(106, 28);
            this.lblFacultyId.TabIndex = 0;
            this.lblFacultyId.Text = "Faculty ID";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(304, 164);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(135, 164);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(40, 339);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpSearch.Size = new System.Drawing.Size(1140, 116);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(845, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(748, 34);
            this.txtSearch.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(5, 6);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grpFacultyList
            // 
            this.grpFacultyList.Controls.Add(this.dgvFaculty);
            this.grpFacultyList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFacultyList.Location = new System.Drawing.Point(41, 485);
            this.grpFacultyList.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpFacultyList.Name = "grpFacultyList";
            this.grpFacultyList.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpFacultyList.Size = new System.Drawing.Size(1140, 232);
            this.grpFacultyList.TabIndex = 3;
            this.grpFacultyList.TabStop = false;
            this.grpFacultyList.Text = "Faculty List";
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.AllowUserToResizeRows = false;
            this.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaculty.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaculty.ColumnHeadersHeight = 45;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFacultyID,
            this.clnFacultyName});
            this.dgvFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFaculty.Location = new System.Drawing.Point(1, 29);
            this.dgvFaculty.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvFaculty.MultiSelect = false;
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersVisible = false;
            this.dgvFaculty.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvFaculty.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaculty.RowTemplate.Height = 28;
            this.dgvFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaculty.Size = new System.Drawing.Size(1138, 201);
            this.dgvFaculty.TabIndex = 0;
            this.dgvFaculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellContentClick);
            // 
            // clnFacultyID
            // 
            this.clnFacultyID.DataPropertyName = "FacultyId";
            this.clnFacultyID.HeaderText = "Faculty ID";
            this.clnFacultyID.MinimumWidth = 8;
            this.clnFacultyID.Name = "clnFacultyID";
            this.clnFacultyID.ReadOnly = true;
            // 
            // clnFacultyName
            // 
            this.clnFacultyName.DataPropertyName = "FacultyName";
            this.clnFacultyName.HeaderText = "Faculty Name";
            this.clnFacultyName.MinimumWidth = 8;
            this.clnFacultyName.Name = "clnFacultyName";
            this.clnFacultyName.ReadOnly = true;
            // 
            // FacultyControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpFacultyList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpFacultyInformation);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FacultyControl";
            this.Size = new System.Drawing.Size(1200, 750);
            this.Load += new System.EventHandler(this.FacultyControl_Load);
            this.grpFacultyInformation.ResumeLayout(false);
            this.grpFacultyInformation.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpFacultyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFacultyInformation;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblFacultyId;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpFacultyList;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFacultyName;
    }
}
