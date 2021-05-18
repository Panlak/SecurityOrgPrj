using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.repository;
using SecurityOrgPrj.Data.ViewRepository;

namespace SecurityOrgPrj
{



	public class Startup
	{

		public IConfiguration Configuration { get; }

		public Startup(IHostEnvironment hostEnv)
		{
			Configuration = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbConnect.json").Build();
		}


		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			services.AddDbContext<AppDBContent>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
			services.AddTransient<IAllCountries, CountryRep>();
			services.AddTransient<IAllCity, CityRep>();
			



			services.AddTransient<IAllSubscriptions, SubscriptionRepository>();

			services.AddTransient<ISubscribers, SubscribersRepository>();

			
			services.AddTransient<IALlService, ServiceRepository>();

			services.AddTransient<IallEvents, EventsRepository>();

			services.AddControllersWithViews();
			services.AddMvc();

			services.AddSession();

		}


		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseRouting();
			app.UseStaticFiles();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Country}/{action=ListView}/{id?}");
			});


		}


	}
}
