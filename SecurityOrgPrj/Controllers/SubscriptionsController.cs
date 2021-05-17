using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Controllers
{
	public class SubscriptionController : Controller
	{


		public IAllSubscriptions _IAllSubscriptions;
		

		public SubscriptionController(IAllSubscriptions IAllSubscriptions)
		{
			_IAllSubscriptions = IAllSubscriptions;
		}


		public ViewResult AllSubscription()
		{
			return View(_IAllSubscriptions.Subscriptions);
		}

		public RedirectToActionResult DeleteSubscription()
		{
			_IAllSubscriptions.RemoveSubscription();
			return RedirectToAction("AllSubscription");
		}

	}
}
