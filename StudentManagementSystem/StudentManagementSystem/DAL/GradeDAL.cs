using System;
using System.Data;
using System.Data.SQLite;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public class GradeDAL : IGradeDAL
    {
        public DataTable GetAllGrades()
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT g.StudentID, s.FullName AS StudentName, c.CourseName, g.Score
                    FROM Grade g
                    JOIN Student s ON g.StudentID = s.StudentID
                    JOIN Course c ON g.CourseID = c.CourseID";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void SaveGrade(Grade grade)
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Grade (StudentID, CourseID, Score)
                    VALUES (@StudentID, @CourseID, @Score)
                    ON CONFLICT(StudentID, CourseID) DO UPDATE SET Score = excluded.Score";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", grade.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", grade.CourseID);
                    cmd.Parameters.AddWithValue("@Score", grade.Score);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetStudents()
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = "SELECT StudentID, FullName, Gender FROM Student";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void DeleteGrade(string studentID, string courseID)
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM Grade WHERE StudentID = @StudentID AND CourseID = @CourseID";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
