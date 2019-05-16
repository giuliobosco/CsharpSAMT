using System.Linq;
using Donatore.DA.Models;

namespace Donatore.DA.Services {
	public interface IDataRepository<T> where T : BaseEntitiy
	{
		T Get(int id);
		IQueryable<T> Get();
		T Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}