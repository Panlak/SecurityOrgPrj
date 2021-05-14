using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.repository
{
	public class CountryRep : IAllCountries
	{

		private readonly AppDBContent appDbContent;

		public CountryRep(AppDBContent appDbContent)
		{
			this.appDbContent = appDbContent;
		}



		public IEnumerable<Countries> Countries => appDbContent.Country;

	}
}
