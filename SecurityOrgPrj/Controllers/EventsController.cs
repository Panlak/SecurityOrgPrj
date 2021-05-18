using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Controllers
{
	public class EventsController : Controller
	{
		public IallEvents _IallEvents;

		public EventsController(IallEvents IallEvents)
		{
			_IallEvents = IallEvents;
		}

		public ViewResult allEvents()
		{
			return View(_IallEvents.Events);
		}

	}
}
