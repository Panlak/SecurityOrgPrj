
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SecurityOrgPrj.Data.Models
{
	[Table("DeparutureInfo")]
	
	public class DeparutureInfo 
	{
	

		
		public int DeparutureInfoId { get; set; }
		
		public string Notes { get; set; }
		[Required]
		public DateTime DepartureTime { get; set; }
		public int EventsId { get; set; }
		public int EventsSubscriptionId { get; set; }
		public int EventsSubscriptionServiceId { get; set; }
		public int EventsSubscriptionServiceSecurityOrganizationId { get; set; }
		public int EventsSubscriptionCustomerId { get; set; }
		public int StaffId { get; set; }


		//key
		public virtual Events Events { get; set; }





	}


}
