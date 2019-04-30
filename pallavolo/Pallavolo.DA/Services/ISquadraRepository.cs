using System.Linq;
using Pallavolo.DA.Models;

namespace Pallavolo.DA.Services {
	public interface ISquadraRepository : IDataRepository<Squadra> {
		new IQueryable<Squadra> Get();
	}
}