
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.repository
{
	public class CityRep : IAllCity
	{
		private readonly AppDBContent appDbContent;
		public CityRep(AppDBContent appDbContent)
		{
			this.appDbContent = appDbContent;
		}

		public IEnumerable<City> City => appDbContent.City;
	}
}
