namespace Donatore.DA.Services {
	public class DonatoreDbRepository : DbDataRepository<AppDbContext, Models.Donatore>, IDonatoreRepository {
		public DonatoreDbRepository(AppDbContext ctx) : base(ctx) {
			
		}
	}
}