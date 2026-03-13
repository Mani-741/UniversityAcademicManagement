using Microsoft.EntityFrameworkCore;
using UniversityAcademicManagementSystem.Models;
namespace UniversityAcademicManagementSystem.Data
{
	public class UniversityDbContext : DbContext
	{

		public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) 
		{
		
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Grade> Grades { get; set; }
		public DbSet<AcademicRecord> AcademicRecords { get; set; }
	}
}
