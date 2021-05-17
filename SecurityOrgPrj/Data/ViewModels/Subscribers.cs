using SecurityOrgPrj.Data.Models;
using SecurityOrgPrj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.ViewModels
{
	public class Subscribers
	{
	
		public Customer Customer { get; set; }
		
		public Subscription Subscription { get; set; }
	
		public City City { get; set; }
	
		public Service Service { get; set; }

		public SecurityOrganization SecurityOrganization { get; set; }
	}
}
