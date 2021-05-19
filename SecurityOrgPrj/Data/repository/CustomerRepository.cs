using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.repository
{
	public class CustomerRepository : IallCustomers
	{
		public AppDBContent _AppDBContent;

		public CustomerRepository(AppDBContent AppDBContent)
		{
			_AppDBContent = AppDBContent;
		}

		public IEnumerable<Customer> Customer => _AppDBContent.Customer;


	}
}
