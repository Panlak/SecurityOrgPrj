using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;

namespace SecurityOrgPrj.Controllers
{
	public class CountryController : Controller
	{
		private readonly IAllCountries _AllCountry;

		public CountryController(IAllCountries Iallcountries)
		{
			_AllCountry = Iallcountries;
		}
		public ViewResult ListView()
		{
			var country = _AllCountry.Countries;
			return View(country);
		}

	}
}
