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

		public async Task<IActionResult> RemoveSub(int id)
		{

			if (id != null)
			{
				var sub = _IAllSubscriptions.Subscriptions.FirstOrDefault(x => x.SubscriptionId == id);
					_IAllSubscriptions.Remove(sub);
					return RedirectToAction("AllSubscription");
				
			}
			return NotFound();

		}
	}
}

