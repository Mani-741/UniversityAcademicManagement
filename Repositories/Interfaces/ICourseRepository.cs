using UniversityAcademicManagementSystem.Models;

namespace UniversityAcademicManagementSystem.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        void AddCourse(Course course);
        Course GetCourseDetails(int id);
        IEnumerable<Course> ListCoursesBySemester(string semester);
        void UpdateCourse(Course course);
    }
}