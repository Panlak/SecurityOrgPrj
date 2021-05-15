
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.Models
{
	[Table("Events")]
	public class Events
	{
		
		public int EventsId { get; set; }

		public int SubscriptionId { get; set; }

		public int SubscriptionServiceId { get; set; }

		public int SubscriptionServiceSecurityOrganizationId { get; set; }

		public int SubscriptionCustomerId { get; set; }
		[Required]
		public string Event_Type { get; set; }
		[Required]
		public DateTime Time_call { get; set; }
		[Required]
		public string Priority { get; set; }

		public string Notes { get; set; }

		


		//Keys
		public virtual Subscription Subscription { get; set; }
		public virtual ICollection<DeparutureInfo> DeparutureInfo { get; set; }
	}
}
