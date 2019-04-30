using System.Linq;
using Pallavolo.DA.Models;

namespace Pallavolo.DA.Services {
	public interface IDataRepository<T> where T : BaseEntity {
		T Get(int id);
		IQueryable<T> Get();
		T Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}