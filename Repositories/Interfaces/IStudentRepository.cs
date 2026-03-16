using UniversityAcademicManagementSystem.Models;

namespace UniversityAcademicManagementSystem.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student GetStudentDetails(int id);
        void RegisterStudent(Student student);
        void UpdateProfile(Student student);
    }
}