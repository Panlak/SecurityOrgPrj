using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.ViewRepository
{
	public class SubscribersRepository : ISubscribers
	{
		private readonly AppDBContent appDbContent;

		public SubscribersRepository(AppDBContent appDbContent)
		{
			this.appDbContent = appDbContent;

			
		}

		public List<SecurityOrganization> SecurityOrganization => appDbContent.SecurityOrganization.ToList();

		List<Customer> ISubscribers.Customer => appDbContent.Customer.ToList();

		List<Subscription> ISubscribers.Subscription => appDbContent.Subscription.ToList();

		List<City> ISubscribers.City => appDbContent.City.ToList();

		List<Service> ISubscribers.Service => appDbContent.Service.ToList();
	}
}
