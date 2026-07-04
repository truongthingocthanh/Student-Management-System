using System;
using System.Collections.Generic;
using System.Data.SQLite;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public class StudentDALSQLite : IStudentDAL
    {
        private const string CONN = "Data Source=data.sqlite;Version=3;";
        private SQLiteConnection con;
        private string error = "";

        public StudentDALSQLite()
        {
            con = new SQLiteConnection(CONN);
            AutoFixDatabase(); // Ép phần mềm tự sửa CSDL ngay khi khởi tạo
        }

        // Hàm bí mật tự động thêm cột ImagePath nếu nó chưa tồn tại
        private void AutoFixDatabase()
        {
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("ALTER TABLE Student ADD COLUMN ImagePath TEXT;", con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                // Lơ đi nếu cột đã tồn tại
            }
            finally
            {
                con.Close();
            }
        }

        public string GetError() => error;

        // 1. Lấy danh sách
        public List<Student> GetAll()
        {
            var list = new List<Student>();
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Student", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Student
                    {
                        ID = reader["StudentID"].ToString(),
                        FullName = reader["FullName"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                        ClassID = reader["ClassID"].ToString(),
                        ImagePath = reader["ImagePath"]?.ToString() // Đọc đường dẫn ảnh
                    });
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        // 2. Thêm mới sinh viên
        public bool Add(Student student)
        {
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("INSERT INTO Student (StudentID, FullName, Gender, DateOfBirth, ClassID, ImagePath) VALUES (@id, @name, @gender, @dob, @classId, @image)", con);

                cmd.Parameters.AddWithValue("@id", student.ID);
                cmd.Parameters.AddWithValue("@name", student.FullName);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.Parameters.AddWithValue("@dob", student.DateOfBirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@classId", student.ClassID);
                cmd.Parameters.AddWithValue("@image", student.ImagePath ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // 3. Sửa sinh viên
        public bool Update(Student student)
        {
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("UPDATE Student SET FullName = @name, Gender = @gender, DateOfBirth = @dob, ClassID = @classId, ImagePath = @image WHERE StudentID = @id", con);

                cmd.Parameters.AddWithValue("@id", student.ID);
                cmd.Parameters.AddWithValue("@name", student.FullName);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.Parameters.AddWithValue("@dob", student.DateOfBirth.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@classId", student.ClassID);
                cmd.Parameters.AddWithValue("@image", student.ImagePath ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        // 4. Xóa sinh viên
        public bool Delete(string studentID)
        {
            try
            {
                con.Open();
                var cmd = new SQLiteCommand("DELETE FROM Student WHERE StudentID = @id", con);
                cmd.Parameters.AddWithValue("@id", studentID);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}