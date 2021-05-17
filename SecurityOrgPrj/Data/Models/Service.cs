using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Models
{
	public class Service
	{
		[Required]
		public int ServiceId { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public string Description { get; set; }
		[Required]
		public int SecurityOrganizationId { get; set; }


		public virtual ICollection<Subscription> Subscription { get; set; }

	}
}
