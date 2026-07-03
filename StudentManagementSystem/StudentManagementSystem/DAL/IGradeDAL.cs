using System.Data;
using StudentManagementSystem.Entity;

namespace StudentManagementSystem.DAL
{
    public interface IGradeDAL
    {
        DataTable GetAllGrades();
        void SaveGrade(Grade grade);
        DataTable GetStudents();
        void DeleteGrade(string studentID, string courseID);
    }
}
