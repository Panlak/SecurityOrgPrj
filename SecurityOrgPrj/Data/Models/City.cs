using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SecurityOrgPrj.Data.Models
{
	public class City
	{
		public int CityId { get; set; }
		[Required]
		public string CityName { get; set; }
		
		public virtual ICollection<SecurityOrganization> SecurityOrganizationId { get; set; }
		public virtual ICollection<Customer> Customer { get; set; }	
		public virtual ICollection<Staff> Staff { get; set; }
	}
}
