using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentManagementSystem.GUI
{
    public partial class LoginForm : Form
    {
        private const string CONN = "Data Source=data.sqlite;Version=3;";

        public string LoggedInUsername => txtUsername.Text.Trim();

        public LoginForm()
        {
            InitializeComponent();
            AutoCreateDatabase(); // Đổi tên hàm cho oai vì giờ nó tạo cả DB
        }

        private void AutoCreateDatabase()
        {
            using (var con = new SQLiteConnection(CONN))
            {
                try
                {
                    con.Open();

                    // 1. Ép tạo bảng Account (nếu chưa có)
                    var cmdCreateAcc = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Account (Username TEXT PRIMARY KEY, Password TEXT, Role TEXT);", con);
                    cmdCreateAcc.ExecuteNonQuery();

                    // 2. ÉP TẠO BẢNG STUDENT (NẾU CHƯA CÓ) - CHÍNH LÀ ĐOẠN GIẢI QUYẾT LỖI CỦA BẠN NÈ
                    var cmdCreateStudent = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Student (ID TEXT PRIMARY KEY, FullName TEXT, Gender TEXT, DateOfBirth DATETIME, ClassID TEXT, ImagePath TEXT);", con);
                    cmdCreateStudent.ExecuteNonQuery();

                    // 3. Bảo trì bảng Account cũ (nếu lỡ thiếu cột Role)
                    try
                    {
                        var cmdAlter = new SQLiteCommand("ALTER TABLE Account ADD COLUMN Role TEXT DEFAULT 'Admin';", con);
                        cmdAlter.ExecuteNonQuery();
                    }
                    catch { }

                    // 4. Tạo sẵn tài khoản admin mặc định
                    var cmdCheck = new SQLiteCommand("SELECT COUNT(*) FROM Account WHERE Username = 'admin'", con);
                    long count = (long)cmdCheck.ExecuteScalar();

                    if (count == 0)
                    {
                        var cmdInsert = new SQLiteCommand("INSERT INTO Account (Username, Password, Role) VALUES ('admin', '123456', 'Admin')", con);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                catch { }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter Username and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var con = new SQLiteConnection(CONN))
            {
                try
                {
                    con.Open();
                    var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Account WHERE Username = @u AND Password = @p", con);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
<<<<<<< Updated upstream
=======

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
    }
}