using Donatore.DA.Models;

namespace Donatore.DA.Services {
	public class SangueDbRepository : DbDataRepository<AppDbContext, Sangue>, ISangueRepository {
		public SangueDbRepository(AppDbContext ctx) : base(ctx) {
			
		}
	}
}