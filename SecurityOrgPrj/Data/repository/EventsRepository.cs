using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.repository
{
	public class EventsRepository : IallEvents
	{
		public AppDBContent _AppDBContent;


		public EventsRepository(AppDBContent AppDBContent)
		{ _AppDBContent = AppDBContent; }

		public IEnumerable<Events> Events => _AppDBContent.Events;
	}
}
