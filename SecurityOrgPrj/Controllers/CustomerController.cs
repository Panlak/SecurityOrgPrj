using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Controllers
{
	public class CustomerController : Controller
	{
		public IallCustomers _IallCustomers;

		public CustomerController (IallCustomers IallCustomers)
		{
			_IallCustomers = IallCustomers;
		}

		public ViewResult AllCustomers()
		{
			return View(_IallCustomers.Customer);
		}

		

	}
}
