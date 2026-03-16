using UniversityAcademicManagementSystem.Models;

namespace UniversityAcademicManagementSystem.Repositories.Interfaces
{
    public interface ITranscriptRepository
    {
        double GenerateTranscript(int studentId);
        IEnumerable<AcademicRecord> GetAcademicRecord(int studentId);
    }
}