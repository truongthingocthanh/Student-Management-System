using System;
using System.Data;
using StudentManagementSystem.DAL;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.BLL
{
    public class CourseBLL
    {
        private CourseDAL courseDAL = new CourseDAL();

        public DataTable GetAllCourses()
        {
            return courseDAL.GetAllCourses();
        }

        public void AddCourse(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseID))
                throw new Exception("Mã môn không được để trống!");

            if (string.IsNullOrWhiteSpace(course.CourseName))
                throw new Exception("Tên môn không được để trống!");

            if (course.Credits <= 0)
                throw new Exception("Số tín chỉ phải lớn hơn 0!");

            courseDAL.AddCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseID))
                throw new Exception("Mã môn không được để trống!");

            if (string.IsNullOrWhiteSpace(course.CourseName))
                throw new Exception("Tên môn không được để trống!");

            if (course.Credits <= 0)
                throw new Exception("Số tín chỉ phải lớn hơn 0!");

            courseDAL.UpdateCourse(course);
        }

        public void DeleteCourse(string courseID)
        {
            if (string.IsNullOrWhiteSpace(courseID))
                throw new Exception("Mã môn không được để trống!");

            courseDAL.DeleteCourse(courseID);
        }
    }
}