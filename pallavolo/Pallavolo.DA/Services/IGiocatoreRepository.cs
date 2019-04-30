using System.Linq;
using Pallavolo.DA.Models;

namespace Pallavolo.DA.Services {
	public interface IGiocatoreRepository : IDataRepository<Giocatore> {
		new IQueryable<Giocatore> Get();
	}
}