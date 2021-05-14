using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Models
{
	public class City
	{
		public int CityId { get; set; }
		public string CityName { get; set; }
		public virtual ICollection<SecurityOrganization> SecurityOrganizationId { get; set; }
		public virtual ICollection<Customer> Customer { get; set; }
	}
}
