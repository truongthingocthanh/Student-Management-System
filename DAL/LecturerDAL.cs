using System.Collections.Generic;
using System.Data.SQLite;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.DAL
{
    internal class LecturerDAL
    {
        // Lấy danh sách giảng viên
        public List<Lecturer> GetAllLecturers()
        {
            List<Lecturer> list = new List<Lecturer>();

            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Lecturer";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lecturer lecturer = new Lecturer();

                        lecturer.LecturerID = reader["LecturerID"].ToString();
                        lecturer.FullName = reader["FullName"].ToString();
                        lecturer.Gender = reader["Gender"].ToString();
                        lecturer.Degree = reader["Degree"].ToString();
                        lecturer.Faculty = reader["Faculty"].ToString();

                        list.Add(lecturer);
                    }
                }
            }

            return list;
        }

        // Thêm giảng viên
        public bool AddLecturer(Lecturer lecturer)
        {
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Lecturer
                               (LecturerID, FullName, Gender, Degree, Faculty)
                               VALUES
                               (@id, @name, @gender, @degree, @faculty)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", lecturer.LecturerID);
                cmd.Parameters.AddWithValue("@name", lecturer.FullName);
                cmd.Parameters.AddWithValue("@gender", lecturer.Gender);
                cmd.Parameters.AddWithValue("@degree", lecturer.Degree);
                cmd.Parameters.AddWithValue("@faculty", lecturer.Faculty);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật giảng viên
        public bool UpdateLecturer(Lecturer lecturer)
        {
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Lecturer
                               SET FullName=@name,
                                   Gender=@gender,
                                   Degree=@degree,
                                   Faculty=@faculty
                               WHERE LecturerID=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", lecturer.LecturerID);
                cmd.Parameters.AddWithValue("@name", lecturer.FullName);
                cmd.Parameters.AddWithValue("@gender", lecturer.Gender);
                cmd.Parameters.AddWithValue("@degree", lecturer.Degree);
                cmd.Parameters.AddWithValue("@faculty", lecturer.Faculty);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa giảng viên
        public bool DeleteLecturer(string id)
        {
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Lecturer WHERE LecturerID=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Tìm kiếm giảng viên
        public List<Lecturer> SearchLecturer(string keyword)
        {
            List<Lecturer> list = new List<Lecturer>();

            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT *
                               FROM Lecturer
                               WHERE LecturerID LIKE @key
                                  OR FullName LIKE @key
                                  OR Faculty LIKE @key";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lecturer lecturer = new Lecturer();

                        lecturer.LecturerID = reader["LecturerID"].ToString();
                        lecturer.FullName = reader["FullName"].ToString();
                        lecturer.Gender = reader["Gender"].ToString();
                        lecturer.Degree = reader["Degree"].ToString();
                        lecturer.Faculty = reader["Faculty"].ToString();

                        list.Add(lecturer);
                    }
                }
            }

            return list;
        }
    }
}