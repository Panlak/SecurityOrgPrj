using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface ISubscribers
	{
		public List<Customer> Customer { get; }
		public List<Subscription> Subscription { get; }
		public List<City> City { get; }
		public List<Service> Service { get; }
		public List<SecurityOrganization> SecurityOrganization { get; }
	}
}
