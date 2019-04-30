using System.Linq;
using Pallavolo.DA.Models;

namespace Pallavolo.DA.Services {
	public class GiocatoreRepository : DbDataRepository<AppDbContext, Giocatore>, IGiocatoreRepository {
		public GiocatoreRepository(AppDbContext context) : base(context) { }

		public override IQueryable<Giocatore> Get() {
			return base.Get().OrderBy(giocatore => giocatore.Nome);
		}
	}
}