using System.Data;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public interface ICourseDAL
    {
        DataTable GetAllCourses();
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(string courseID);
    }
}
