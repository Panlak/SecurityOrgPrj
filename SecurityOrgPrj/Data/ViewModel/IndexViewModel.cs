using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.ViewModel
{
	public class IndexViewModel
	{
		public IEnumerable<Countries> Countries { get; set; }
		public IEnumerable<City> City { get; set; }
	}
}
