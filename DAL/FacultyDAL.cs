using System.Collections.Generic;
using System.Data.SQLite;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.DAL
{
    internal class FacultyDAL
    {
        // Lấy toàn bộ khoa
        public List<Faculty> GetAllFaculties()
        {
            List<Faculty> list = new List<Faculty>();

            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Faculty";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Faculty faculty = new Faculty();

                    faculty.FacultyId = reader["FacultyId"].ToString();
                    faculty.FacultyName = reader["FacultyName"].ToString();

                    list.Add(faculty);
                }
            }

            return list;
        }

        // Thêm khoa
        public bool AddFaculty(Faculty faculty)
        {
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Faculty(FacultyId,FacultyName)
                               VALUES(@id,@name)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", faculty.FacultyId);
                cmd.Parameters.AddWithValue("@name", faculty.FacultyName);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật khoa
        public bool UpdateFaculty(Faculty faculty)
        {
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Faculty
                               SET FacultyName=@name
                               WHERE FacultyId=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", faculty.FacultyId);
                cmd.Parameters.AddWithValue("@name", faculty.FacultyName);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa khoa
        public bool DeleteFaculty(string facultyId)
        {
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Faculty WHERE FacultyId=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", facultyId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm khoa
        public List<Faculty> SearchFaculty(string keyword)
        {
            List<Faculty> list = new List<Faculty>();

            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT *
                               FROM Faculty
                               WHERE FacultyId LIKE @key
                               OR FacultyName LIKE @key";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Faculty faculty = new Faculty();

                    faculty.FacultyId = reader["FacultyId"].ToString();
                    faculty.FacultyName = reader["FacultyName"].ToString();

                    list.Add(faculty);
                }
            }

            return list;
        }
    }
}