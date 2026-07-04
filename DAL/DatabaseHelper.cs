using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString =
            @"Data Source=D:\Fix\WindowsFormsApp1\WindowsFormsApp1\University.db\database.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Hiện đường dẫn file database đang mở
            MessageBox.Show(connection.FileName);

            // Hiện tất cả các bảng trong database
            SQLiteCommand cmd = new SQLiteCommand(
                "SELECT name FROM sqlite_master WHERE type='table';",
                connection);

            SQLiteDataReader reader = cmd.ExecuteReader();

            string tables = "";

            while (reader.Read())
            {
                tables += reader["name"].ToString() + Environment.NewLine;
            }

            MessageBox.Show(tables);

            return connection;
        }
    }
}