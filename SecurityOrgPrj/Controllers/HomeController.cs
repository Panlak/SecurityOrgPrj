using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.ViewModel;

namespace SecurityOrgPrj.Controllers
{
	public class HomeController : Controller
	{
		public readonly IAllView _IAllView;
		public HomeController(IAllView IallView)
		{
			_IAllView = IallView;
		}

		public ViewResult Result(int id)
		{
			var country = new IndexViewModel() { City = _IAllView.City, Countries = _IAllView.Countries };

			return View(country);


		}
	}
}
