using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pallavolo.DA.Models;

namespace Pallavolo.DA {
	public class AppDbContext : DbContext {
		public DbSet<Squadra> Squadre { get; set; }
		public DbSet<Giocatore> Giocatori { get; set; }
		

		// costruttore per web app
		public AppDbContext() {
			
		}

		// costruttore per migrazioni
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
			
		}

		// connessione per la preparazione della db
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			if (!optionsBuilder.IsConfigured) {
				optionsBuilder.UseSqlite("Data Source=./pallavolo.db");
				//optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=1234qwer;database=pallavolo");
			}
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			//foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
			//	modelBuilder.Entity(entityType.Name).Ignore("IsDirtiy");
			//}

			foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
				var parameter = Expression.Parameter(entityType.ClrType);

				var propertyMethodInfo =
					typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(DateTime));
				var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter,
					Expression.Constant("Deleted"));

				var minDate =
					Expression.Constant(Convert.ChangeType(DateTime.MinValue, typeof(DateTime)));
				BinaryExpression compareExpression =
					Expression.MakeBinary(ExpressionType.LessThanOrEqual, isDeletedProperty,
						minDate);

				var lambda = Expression.Lambda(compareExpression, parameter);

				modelBuilder.Entity(entityType.ClrType).HasQueryFilter(lambda);
			}
		}

		private void OnBeforeSaving() {
			foreach (var entry in ChangeTracker.Entries()) {
				switch (entry.State) {
					case EntityState.Added:
						entry.Property("Added").CurrentValue = DateTime.Now;
						entry.Property("Modified").CurrentValue = DateTime.Now;
						entry.Property("Deleted").CurrentValue = DateTime.MinValue;
						break;
					case EntityState.Modified:
						entry.Property("Modified").CurrentValue = DateTime.Now;
						break;
					case EntityState.Deleted:
						entry.Property("Deleted").CurrentValue = DateTime.Now;
						entry.State = EntityState.Deleted;
						break;
				}
			}
		}

		public override int SaveChanges() {
			OnBeforeSaving();
			return base.SaveChanges();
		}

		public override Task<int> SaveChangesAsync(bool acceptedAllChangesOnSuccess,
		                                           CancellationToken cancellationToken =
			                                           new CancellationToken()) {
			OnBeforeSaving();
			return base.SaveChangesAsync(acceptedAllChangesOnSuccess, cancellationToken);
		}
	}
}