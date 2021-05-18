using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
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

		public RedirectToActionResult DeleteSubscription(int id )
		{
			var item = _IAllSubscriptions.Subscriptions.FirstOrDefault(i => i.SubscriptionId == id);
			_IAllSubscriptions.RemoveSubscription(item);
			return RedirectToAction("AllSubscription");
		}



		
		public IActionResult EditSub(int id,Subscription Subscription)
		{
			var item = _IAllSubscriptions.Subscriptions.FirstOrDefault(x=>x.SubscriptionId == id);
			Subscription.SubscriptionId = id;
			if (ModelState.IsValid)
			{
				_IAllSubscriptions.EditSubscription(Subscription);
				return RedirectToAction("AllSubscription");
			}

			return View(item);
		}


	}
}

