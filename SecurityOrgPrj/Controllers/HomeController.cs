using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;

using System.Linq;
namespace SecurityOrgPrj.Controllers
{
	public class HomeController : Controller
	{
		public IAllSubscriptions _IAllSubscriptions;
		public Subscription _Subscription;

		public HomeController(IAllSubscriptions IAllSubscriptions)
		{
			_IAllSubscriptions = IAllSubscriptions;
		}


		public IActionResult Result(Subscription Subscription)
		{


			if (ModelState.IsValid)
			{
				_IAllSubscriptions.CreateSubscription(Subscription);
				return RedirectToAction("Complete");
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
