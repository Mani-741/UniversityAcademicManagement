namespace UniversityAcademicManagementSystem.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		bool Add(T entity);
		bool Update(T entity);
		bool Delete(int id);
		T GetById(int id);
		IEnumerable<T> GetAll();
	}
}
