using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface IAllView
	{
		IEnumerable<Countries> Countries { get; }
		IEnumerable<City> City { get; }
	}
}
