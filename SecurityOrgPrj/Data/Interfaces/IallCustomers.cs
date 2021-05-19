using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface IallCustomers
	{
		public IEnumerable<Customer> Customer { get; }
	}
}
