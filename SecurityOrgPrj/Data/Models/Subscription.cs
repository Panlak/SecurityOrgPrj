using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SecurityOrgPrj.Data.Models
{
	[Table("Subscription")]
	public partial class Subscription
	{
		public int SubscriptionId { get; set; }


		[ForeignKey("Service")]
		public  int ServiceId { get; set; }
		[ForeignKey("ServiceSecurityOrganization")]
		public  int ServiceSecurityOrganizationId { get; set; }

		public int CustomerId { get; set; }

		public virtual Service Service { get; set; }






		public string SubscriptionName { get; set; }
		public int Price { get; set; }
		[DataType(DataType.Date)]
		public DateTime StartSubscription { get; set; }
		[DataType(DataType.Date)]
		public DateTime EndtSubscription { get; set; }


	}
}
