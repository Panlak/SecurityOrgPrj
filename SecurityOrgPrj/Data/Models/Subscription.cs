using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SecurityOrgPrj.Data.Models
{
	[Table("Subscription")]
	public partial class Subscription
	{

		[Display(Name = "Subscription Id")]
		public int SubscriptionId { get; set; }

		[Display(Name = "Service Id")]
		public  int ServiceId { get; set; }


		[Display(Name = "Security Organization Id")]

		public  int ServiceSecurityOrganizationId { get; set; }

		[Display(Name = "Customer Id")]
		public int CustomerId { get; set; }

		[Display(Name = "Name Subscription")]
		[StringLength(20)]
		[Required]
		public string SubscriptionName { get; set; }

		[Required]
		[Display(Name = "Enter Price")]
		public int Price { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Start Subscription")]
		public DateTime StartSubscription { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "End Subscription")]
		public DateTime EndSubscription { get; set; }







		[BindNever]
		public virtual Service Service { get; set; }
		[BindNever]
		public virtual ICollection<Events> Events { get; set; }

	}
}
