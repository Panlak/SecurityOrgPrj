using SecurityOrgPrj.Data.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface IAllCity
	{
		IEnumerable<City> City { get; }
	}
}
