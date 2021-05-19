using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.repository
{
	public class ServiceRepository : IALlService
	{
		public AppDBContent _AppDBContent;

		public ServiceRepository(AppDBContent AppDBContent)
		{
			_AppDBContent = AppDBContent;
		}

		public IEnumerable<Service> Service => _AppDBContent.Service;

		public void Remove(Service Service)
		{
			var item = _AppDBContent.Service.Where(x => x.ServiceId == Service.ServiceId).FirstOrDefault();

			_AppDBContent.Service.Remove(item);

			_AppDBContent.SaveChanges();
		}

		public async void Edit(Service Service)
		{
			_AppDBContent.Service.Update(Service);
			_AppDBContent.SaveChanges();
		}

		

	}
}
