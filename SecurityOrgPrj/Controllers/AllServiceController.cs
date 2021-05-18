using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
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

		public ViewResult GETService()
		{
			return View(_IALlService.Service);
		}
	}
}
