using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;

using System.Linq;
namespace SecurityOrgPrj.Controllers
{
	public class HomeController : Controller
	{
		public IAllSubscriptions _IAllSubscriptions;
		public IALlService _IALlService;
		public IallCustomers _IallCustomers;
		public Subscription _Subscription;

		public HomeController(IAllSubscriptions IAllSubscriptions, IALlService IALlService, IallCustomers IallCustomers)
		{
			_IAllSubscriptions = IAllSubscriptions;
			_IALlService = IALlService;
			_IallCustomers = IallCustomers;
		}


		public IActionResult Result(Subscription Subscription)
		{


			if (ModelState.IsValid)
			{
				if (_IallCustomers.Customer.Any(x => x.CustomerId == Subscription.CustomerId))
				if (_IALlService.Service.Any(x => x.ServiceId == Subscription.ServiceId & x.SecurityOrganizationId == Subscription.ServiceSecurityOrganizationId))
				{
					_IAllSubscriptions.CreateSubscription(Subscription);
					return RedirectToAction("Complete");
				}
			}

			return View(Subscription);
		}

		public IActionResult Complete()
		{
			ViewBag.Message = "Subscription Added";
			return View();
		}
		
	}
}
