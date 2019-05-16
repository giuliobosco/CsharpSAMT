using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Donatore.DA.Models;
using Microsoft.EntityFrameworkCore;

namespace Donatore.DA {
	public class AppDbContext : DbContext {
		public DbSet<Sangue> Sangue { get; set; }
		public DbSet<Models.Donatore> Donatori { get; set; }

		public AppDbContext() {
			
		}

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
			
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			if (!optionsBuilder.IsConfigured) {
				optionsBuilder.UseSqlite("DataSoure=./donatore.db");
			}
		}

		public override int SaveChanges() {
			OnBeforeSaving();
			return base.SaveChanges();
		}
		
		public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
		{
			OnBeforeSaving();
			return base.SaveChangesAsync(acceptAllChangesOnSuccess,
				cancellationToken);
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
						entry.State = EntityState.Modified;
						break;
					
				}
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				var parameter = Expression.Parameter(entityType.ClrType);

				var propertyMethodInfo = typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(DateTime));
				var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("Deleted"));

				var minDate = Expression.Constant(Convert.ChangeType(DateTime.MinValue, typeof(DateTime)));
				BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.LessThanOrEqual, isDeletedProperty, minDate);

				var lambda = Expression.Lambda(compareExpression, parameter);

				modelBuilder.Entity(entityType.ClrType).HasQueryFilter(lambda);
			}
		}
	}
}