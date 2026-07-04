using StudentManagementSystem.GUI;

namespace StudentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();

            if (login.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên tài khoản vừa đăng nhập thành công
                string currentUser = login.LoggedInUsername;

                // Mở Trang chủ và truyền tên tài khoản vào
                Application.Run(new MainForm(currentUser));
            }
        }
    }
}