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

            // Mở Form Đăng nhập
            LoginForm login = new LoginForm();

            // Kiểm tra kết quả trả về
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}