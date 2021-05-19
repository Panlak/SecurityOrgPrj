using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Controllers
{
	public class AllServiceController : Controller
	{
		public IALlService _IALlService;

		public AllServiceController (IALlService IALlService)
		{
			_IALlService = IALlService;
		}

		public ViewResult allService()
		{
			return View(_IALlService.Service);
		}

		public async Task<IActionResult> RemoveService(int id)
		{
			if (id != null)
			{
				var service = _IALlService.Service.FirstOrDefault(x => x.ServiceId == id);
				if (service != null)
				{
					_IALlService.Remove(service);
					return RedirectToAction("GETService");
				}
			}
			return NotFound();

		}

		public async Task<IActionResult> EditService(int id)
		{
			
			if (id != null)
			{

				var service = _IALlService.Service.FirstOrDefault(x => x.ServiceId == id);
				if (service != null)
				return View(service);
			}
			return NotFound();
			
		}
		[HttpPost]
		public async Task<IActionResult> EditService(Service Service)
		{
			if (ModelState.IsValid)
			{
				_IALlService.Edit(Service);
				return RedirectToAction("GETService");
			}
			return View(Service);

		}

		public ActionResult GETService(string searchString)
		{
			List<Service> Subscribers = _IALlService.Service.ToList();

			var Price = from SUB in Subscribers select SUB;

			if (!String.IsNullOrEmpty(searchString))
			{
				try
				{
					Price = Price.Where(s => s.Price > Convert.ToInt32(searchString));
				}
				catch {};
			}

			return View(Price);
		}


	}
}
