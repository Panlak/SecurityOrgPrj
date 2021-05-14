using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;

namespace SecurityOrgPrj.Controllers
{
	public class CityController : Controller
	{
		private readonly IAllCity _IAllCity;
		public CityController(IAllCity IallCity)
		{
			_IAllCity = IallCity;
		}
		public ViewResult City()
		{
			var City = _IAllCity.City;
			return View(City);
		}
	}
}
