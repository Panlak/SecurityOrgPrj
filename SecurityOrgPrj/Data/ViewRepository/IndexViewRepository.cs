using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.ViewRepository
{
	public class IndexViewRepository : IAllView
	{
		private readonly AppDBContent appDbContent;

		public IndexViewRepository(AppDBContent appDbContent)
		{
			this.appDbContent = appDbContent;
		}

		public IEnumerable<Countries> Countries => appDbContent.Country;

		public IEnumerable<City> City => appDbContent.City;
	}
}
