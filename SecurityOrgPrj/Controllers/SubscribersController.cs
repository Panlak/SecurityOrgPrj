using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Controllers
{
	public class SubscribersController : Controller
	{
		public ISubscribers _ISubscribers;

		public SubscribersController(ISubscribers ISubscribers)
		{
			_ISubscribers = ISubscribers;
		}

		public ViewResult GetSubscribers()
		{
			List<Customer> customer = _ISubscribers.Customer;
			List<Subscription> subscription = _ISubscribers.Subscription;
			List<City> city = _ISubscribers.City;
			List<Service> service = _ISubscribers.Service;
			List<SecurityOrganization> securityorganization = _ISubscribers.SecurityOrganization;






			var multiple = from SECORG in securityorganization

						   join SERVICE in service on SECORG.SecurityOrganizationId equals SERVICE.SecurityOrganizationId 

					

						   join CITY in city on SECORG.CityId equals CITY.CityId

						   join CUSTOMER in customer on CITY.CityId equals CUSTOMER.CityId 

						   join SUBSCRIP in subscription on new {SERVICE.ServiceId, p2 = (int?)SERVICE.SecurityOrganizationId, CUSTOMER.CustomerId }

						   equals new {SUBSCRIP.ServiceId, p2 = (int?)SUBSCRIP.ServiceSecurityOrganizationId, SUBSCRIP.CustomerId }			  

						   into details

						   from SUBSCRIP in details
						   select new Subscribers()
						   {
							   Service = SERVICE,
							   Subscription = SUBSCRIP,
							   Customer = CUSTOMER,
							   City = CITY,
							   SecurityOrganization = SECORG
							   
						   };












			return View();
		}


	}
}
