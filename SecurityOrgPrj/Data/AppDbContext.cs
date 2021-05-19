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
		public DbSet<Events> Events { get; set; }
		public DbSet<Staff> Staff { get; set; }
		public DbSet<DeparutureInfo> DeparutureInfo { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			///////////////////////////////////////////////////////////////////////////////
			builder.Entity<Service>().HasKey(table => new
			{
				table.ServiceId,
				table.SecurityOrganizationId
			});

			builder.Entity<Service>().HasIndex(c => c.ServiceId).IsUnique();     //Unique

			///////////////////////////////////////////////////////////////////////////////
		
			builder.Entity<Subscription>().HasIndex(c => c.SubscriptionId).IsUnique();
			builder.Entity<Subscription>().HasOne(x => x.Service)
			.WithMany(x => x.Subscription)
			.HasForeignKey(x => new 
			{	
				x.ServiceId,
				x.ServiceSecurityOrganizationId
			});
			builder.Entity<Subscription>().HasKey(table => new
			{
				table.SubscriptionId,
				table.ServiceId,				
				table.ServiceSecurityOrganizationId,
				table.CustomerId
			});

			///////////////////////////////////////////////////////////////////////////////
			builder.Entity<Events>().HasOne(table => table.Subscription)
			.WithMany(table => table.Events)
			.HasForeignKey(table => new
			{
				table.SubscriptionId,
				table.SubscriptionServiceId,
				table.SubscriptionServiceSecurityOrganizationId,
				table.SubscriptionCustomerId
			});
			builder.Entity<Events>().HasKey(table => new
			{
				table.EventsId,
				table.SubscriptionId,
				table.SubscriptionServiceId,
				table.SubscriptionServiceSecurityOrganizationId,
				table.SubscriptionCustomerId
			});
			builder.Entity<Events>().HasIndex(c => c.EventsId).IsUnique();  //Unique
			///////////////////////////////////////////////////////////////////////////////

			builder.Entity<DeparutureInfo>().HasOne(table => table.Events)
			.WithMany(table => table.DeparutureInfo)
			.HasForeignKey(table => new
			{
				table.EventsId,
				table.EventsSubscriptionId,
				table.EventsSubscriptionServiceId,
				table.EventsSubscriptionServiceSecurityOrganizationId,
				table.EventsSubscriptionCustomerId
			});
			


			builder.Entity<DeparutureInfo>().HasKey(table => new
			{
				table.DeparutureInfoId,
				table.EventsId,
				table.EventsSubscriptionId,
				table.EventsSubscriptionServiceId,
				table.EventsSubscriptionServiceSecurityOrganizationId,
				table.EventsSubscriptionCustomerId,
				table.StaffId
			});

			builder.Entity<DeparutureInfo>().HasIndex(c => c.DeparutureInfoId).IsUnique(); //Unique

			///////////////////////////////////////////////////////////////////////////////
			
		}

	}
}
