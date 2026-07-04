using System;
using System.Data.SQLite;

namespace StudentManagementSystem.DAL
{
    public class DbConnection
    {
        private static readonly string ConnectionString = "Data Source=data.sqlite;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static void InitializeDatabase()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string createStudentTable = @"
                    CREATE TABLE IF NOT EXISTS Student (
                        StudentID TEXT PRIMARY KEY,
                        FullName TEXT NOT NULL,
                        Gender TEXT NOT NULL
                    );";
                using (var cmd = new SQLiteCommand(createStudentTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string createCourseTable = @"
                    CREATE TABLE IF NOT EXISTS Course (
                        CourseID TEXT PRIMARY KEY,
                        CourseName TEXT NOT NULL,
                        Credits INTEGER NOT NULL
                    );";
                using (var cmd = new SQLiteCommand(createCourseTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string createGradeTable = @"
                    CREATE TABLE IF NOT EXISTS Grade (
                        StudentID TEXT NOT NULL,
                        CourseID TEXT NOT NULL,
                        Score REAL NOT NULL,
                        PRIMARY KEY (StudentID, CourseID),
                        FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON DELETE CASCADE,
                        FOREIGN KEY (CourseID) REFERENCES Course(CourseID) ON DELETE CASCADE
                    );";
                using (var cmd = new SQLiteCommand(createGradeTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string countStudents = "SELECT COUNT(*) FROM Student;";
                long studentCount = 0;
                using (var cmd = new SQLiteCommand(countStudents, conn))
                {
                    studentCount = (long)cmd.ExecuteScalar();
                }

                if (studentCount == 0)
                {
                    string seedStudents = @"
                        INSERT INTO Student (StudentID, FullName, Gender) VALUES 
                        ('SV01', 'Nguyen Van A', 'Male'),
                        ('SV02', 'Tran Thi B', 'Female'),
                        ('SV03', 'Le Van C', 'Male');";
                    using (var cmd = new SQLiteCommand(seedStudents, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                string countCourses = "SELECT COUNT(*) FROM Course;";
                long courseCount = 0;
                using (var cmd = new SQLiteCommand(countCourses, conn))
                {
                    courseCount = (long)cmd.ExecuteScalar();
                }

                if (courseCount == 0)
                {
                    string seedCourses = @"
                        INSERT INTO Course (CourseID, CourseName, Credits) VALUES 
                        ('CS01', 'Lap trinh C#', 3),
                        ('CS02', 'Co so du lieu', 4),
                        ('CS03', 'Lap trinh Web', 3);";
                    using (var cmd = new SQLiteCommand(seedCourses, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                string countGrades = "SELECT COUNT(*) FROM Grade;";
                long gradeCount = 0;
                using (var cmd = new SQLiteCommand(countGrades, conn))
                {
                    gradeCount = (long)cmd.ExecuteScalar();
                }

                if (gradeCount == 0)
                {
                    string seedGrades = @"
                        INSERT INTO Grade (StudentID, CourseID, Score) VALUES 
                        ('SV01', 'CS01', 8.5),
                        ('SV02', 'CS01', 9.0),
                        ('SV01', 'CS02', 7.0);";
                    using (var cmd = new SQLiteCommand(seedGrades, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}