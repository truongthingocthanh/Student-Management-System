using System;
using System.Data;
using StudentManagementSystem.DAL;
using StudentManagementSystem.Entity;
using StudentManagementSystem.Exceptions;

namespace StudentManagementSystem.BLL
{
    public class GradeBLL
    {
        private readonly IGradeDAL gradeDAL = new GradeDAL();
        private readonly ICourseDAL courseDAL = new CourseDAL();

        public DataTable GetAllGrades()
        {
            return gradeDAL.GetAllGrades();
        }

        public DataTable GetStudents()
        {
            return gradeDAL.GetStudents();
        }

        public DataTable GetAllCourses()
        {
            return courseDAL.GetAllCourses();
        }

        public void SaveGrade(Grade grade)
        {
            if (string.IsNullOrWhiteSpace(grade.StudentID))
                throw new Exception("Sinh viên không được để trống!");

            if (string.IsNullOrWhiteSpace(grade.CourseID))
                throw new Exception("Môn học không được để trống!");

            if (grade.Score < 0 || grade.Score > 10)
                throw new DiemKhongHopLeException("Điểm không hợp lệ!");

            gradeDAL.SaveGrade(grade);
        }

        public void DeleteGrade(string studentID, string courseID)
        {
            if (string.IsNullOrWhiteSpace(studentID))
                throw new Exception("Sinh viên không được để trống!");

            if (string.IsNullOrWhiteSpace(courseID))
                throw new Exception("Môn học không được để trống!");

            gradeDAL.DeleteGrade(studentID, courseID);
        }
    }
}
