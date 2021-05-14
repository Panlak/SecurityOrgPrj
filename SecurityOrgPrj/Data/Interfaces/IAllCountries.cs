using SecurityOrgPrj.Models;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface IAllCountries
	{
		IEnumerable<Countries> Countries { get; }
	}
}
