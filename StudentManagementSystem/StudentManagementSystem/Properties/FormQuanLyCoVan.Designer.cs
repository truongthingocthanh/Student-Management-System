#nullable disable
namespace QuanLyGiaoDuc.Presentation
{
    partial class FormQuanLyCoVan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelInputCard = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMaCoVan = new System.Windows.Forms.Label();
            this.txtMaCoVan = new System.Windows.Forms.TextBox();
            this.lblTenCoVan = new System.Windows.Forms.Label();
            this.txtTenCoVan = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.panelGioiTinh = new System.Windows.Forms.Panel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvCoVan = new System.Windows.Forms.DataGridView();
            this.panelInputCard.SuspendLayout();
            this.panelGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoVan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInputCard
            // 
            this.panelInputCard.BackColor = System.Drawing.Color.White;
            this.panelInputCard.Controls.Add(this.lblId);
            this.panelInputCard.Controls.Add(this.txtId);
            this.panelInputCard.Controls.Add(this.lblMaCoVan);
            this.panelInputCard.Controls.Add(this.txtMaCoVan);
            this.panelInputCard.Controls.Add(this.lblTenCoVan);
            this.panelInputCard.Controls.Add(this.txtTenCoVan);
            this.panelInputCard.Controls.Add(this.lblNgaySinh);
            this.panelInputCard.Controls.Add(this.dtpNgaySinh);
            this.panelInputCard.Controls.Add(this.lblGioiTinh);
            this.panelInputCard.Controls.Add(this.panelGioiTinh);
            this.panelInputCard.Controls.Add(this.lblMaLop);
            this.panelInputCard.Controls.Add(this.cboMaLop);
            this.panelInputCard.Controls.Add(this.lblMaKhoa);
            this.panelInputCard.Controls.Add(this.cboMaKhoa);
            this.panelInputCard.Controls.Add(this.btnThem);
            this.panelInputCard.Controls.Add(this.btnSua);
            this.panelInputCard.Controls.Add(this.btnXoa);
            this.panelInputCard.Controls.Add(this.btnLamMoi);
            this.panelInputCard.Location = new System.Drawing.Point(20, 20);
            this.panelInputCard.Name = "panelInputCard";
            this.panelInputCard.Size = new System.Drawing.Size(760, 155);
            this.panelInputCard.TabIndex = 0;
            this.panelInputCard.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInputCard_Paint);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblId.Location = new System.Drawing.Point(15, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(45, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(50, 25);
            this.txtId.TabIndex = 1;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaCoVan
            // 
            this.lblMaCoVan.AutoSize = true;
            this.lblMaCoVan.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMaCoVan.Location = new System.Drawing.Point(110, 23);
            this.lblMaCoVan.Name = "lblMaCoVan";
            this.lblMaCoVan.Size = new System.Drawing.Size(91, 17);
            this.lblMaCoVan.Text = "Advisor Code:";
            // 
            // txtMaCoVan
            // 
            this.txtMaCoVan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCoVan.Location = new System.Drawing.Point(205, 20);
            this.txtMaCoVan.Name = "txtMaCoVan";
            this.txtMaCoVan.Size = new System.Drawing.Size(95, 25);
            this.txtMaCoVan.TabIndex = 2;
            // 
            // lblTenCoVan
            // 
            this.lblTenCoVan.AutoSize = true;
            this.lblTenCoVan.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblTenCoVan.Location = new System.Drawing.Point(310, 23);
            this.lblTenCoVan.Name = "lblTenCoVan";
            this.lblTenCoVan.Size = new System.Drawing.Size(95, 17);
            this.lblTenCoVan.Text = "Advisor Name:";
            // 
            // txtTenCoVan
            // 
            this.txtTenCoVan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenCoVan.Location = new System.Drawing.Point(408, 20);
            this.txtTenCoVan.Name = "txtTenCoVan";
            this.txtTenCoVan.Size = new System.Drawing.Size(140, 25);
            this.txtTenCoVan.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblNgaySinh.Location = new System.Drawing.Point(555, 23);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(84, 17);
            this.lblNgaySinh.Text = "Date of Birth:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(640, 20);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(110, 25);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 68);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 17);
            this.lblGioiTinh.Text = "Gender:";
            // 
            // panelGioiTinh
            // 
            this.panelGioiTinh.Controls.Add(this.radNam);
            this.panelGioiTinh.Controls.Add(this.radNu);
            this.panelGioiTinh.Location = new System.Drawing.Point(80, 60);
            this.panelGioiTinh.Name = "panelGioiTinh";
            this.panelGioiTinh.Size = new System.Drawing.Size(130, 35);
            this.panelGioiTinh.TabIndex = 5;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.radNam.Location = new System.Drawing.Point(5, 7);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(55, 21);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Male";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.radNu.Location = new System.Drawing.Point(70, 7);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(67, 21);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Female";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMaLop.Location = new System.Drawing.Point(220, 68);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(76, 17);
            this.lblMaLop.Text = "Class Code:";
            // 
            // cboMaLop
            // 
            this.cboMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaLop.Location = new System.Drawing.Point(298, 65);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(100, 25);
            this.cboMaLop.TabIndex = 6;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMaKhoa.Location = new System.Drawing.Point(415, 68);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(73, 17);
            this.lblMaKhoa.Text = "Dept Code:";
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaKhoa.Location = new System.Drawing.Point(492, 65);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(100, 25);
            this.cboMaKhoa.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(180, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(290, 110);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Edit";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(510, 110);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvCoVan
            // 
            this.dgvCoVan.Location = new System.Drawing.Point(20, 195);
            this.dgvCoVan.Name = "dgvCoVan";
            this.dgvCoVan.Size = new System.Drawing.Size(760, 275);
            this.dgvCoVan.TabIndex = 12;
            // 
            // FormQuanLyCoVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.dgvCoVan);
            this.Controls.Add(this.panelInputCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLyCoVan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Academic Advisor Management";
            this.panelInputCard.ResumeLayout(false);
            this.panelInputCard.PerformLayout();
            this.panelGioiTinh.ResumeLayout(false);
            this.panelGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoVan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInputCard;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMaCoVan;
        private System.Windows.Forms.TextBox txtMaCoVan;
        private System.Windows.Forms.Label lblTenCoVan;
        private System.Windows.Forms.TextBox txtTenCoVan;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Panel panelGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvCoVan;
    }
}
