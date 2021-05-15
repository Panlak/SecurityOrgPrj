using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SecurityOrgPrj.Data.Models
{
	[Table("Subscription")]
	public partial class Subscription
	{
		public int SubscriptionId { get; set; }


		public  int ServiceId { get; set; }
		
		public  int ServiceSecurityOrganizationId { get; set; }

		public int CustomerId { get; set; }

		public virtual Service Service { get; set; }

		public virtual ICollection<Events> Events { get; set; }



		[Required]
		public string SubscriptionName { get; set; }
		[Required]
		public int Price { get; set; }
		[DataType(DataType.Date)]
		public DateTime StartSubscription { get; set; }
		[DataType(DataType.Date)]
		public DateTime EndtSubscription { get; set; }


	}
}
