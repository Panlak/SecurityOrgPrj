using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Models
{
	public class SecurityOrganization
	{
		public int SecurityOrganizationId { get; set; }
		public string NameOrganization { get; set; }
		public string Email { get; set; }
		public int CountEmployees { get; set; }

		public virtual ICollection<Service> Service { get; set; }
	}
}
