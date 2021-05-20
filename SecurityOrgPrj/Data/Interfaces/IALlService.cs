using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface IALlService
	{
		public IEnumerable<Service> Service { get; }
		void Remove(Service Service);
		void Edit(Service Service);
		void CreateService(Service Service);
	}
}
