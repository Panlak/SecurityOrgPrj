using Microsoft.EntityFrameworkCore;
using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Models;

namespace SecurityOrgPrj
{
	public class AppDBContent : DbContext
	{

		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
		{ }
		public DbSet<Countries> Country { get; set; }
		public DbSet<City> City { get; set; }
		public DbSet<SecurityOrganization> SecurityOrganization { get; set; }
		public DbSet<Service> Service { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Subscription> Subscription { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Service>().HasKey(table => new
			{
				table.SecurityOrganizationId,
				table.ServiceId
			});


			

			builder.Entity<Subscription>().HasOne(x => x.Service)
			.WithMany(x => x.Subscription)
			.HasForeignKey(x => new 
			{	
				x.ServiceId,
				x.ServiceSecurityOrganizationId
			});
			builder.Entity<Subscription>().HasKey(table => new
			{
				table.ServiceId,
				table.ServiceSecurityOrganizationId,
				table.SubscriptionId,
				table.CustomerId
			});

		}

	}
}
