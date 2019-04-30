using System.Linq;
using Pallavolo.DA.Models;

namespace Pallavolo.DA.Services {
	public class SquardaRepository : DbDataRepository<AppDbContext, Squadra>, ISquadraRepository {
		public SquardaRepository(AppDbContext context) : base(context) { }

		public override IQueryable<Squadra> Get() {
			return base.Get().OrderBy(squadra => squadra.Nome);
		}
	}
}