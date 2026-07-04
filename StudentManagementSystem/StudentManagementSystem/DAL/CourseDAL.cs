using System.Data;
using System.Data.SQLite;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public class CourseDAL : ICourseDAL
    {
        public DataTable GetAllCourses()
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = "SELECT CourseID, CourseName, Credits FROM Course";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void AddCourse(Course course)
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Course(CourseID, CourseName, Credits)
                    VALUES (@CourseID, @CourseName, @Credits)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                    cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                    cmd.Parameters.AddWithValue("@Credits", course.Credits);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCourse(Course course)
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE Course
                    SET CourseName = @CourseName, Credits = @Credits
                    WHERE CourseID = @CourseID";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                    cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                    cmd.Parameters.AddWithValue("@Credits", course.Credits);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCourse(string courseID)
        {
            using (SQLiteConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string sql = "DELETE FROM Course WHERE CourseID = @CourseID";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}