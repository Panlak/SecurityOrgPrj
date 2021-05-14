using SecurityOrgPrj.Data.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Models
{
	public class Countries
	{
		public int CountriesId { get; set; }
		public string CountryName { get; set; }
		public virtual ICollection<City> City { get; set; }

	}
}
