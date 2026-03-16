using UniversityAcademicManagementSystem.Models;

namespace UniversityAcademicManagementSystem.Repositories.Interfaces
{
    public interface IEnrollmentRepository
    {
        void DropCourse(int studentId, int courseId);
        void EnrollCourse(int studentId, int courseId);
        IEnumerable<Enrollment> GetEnrolledCourses(int studentId);
    }
}