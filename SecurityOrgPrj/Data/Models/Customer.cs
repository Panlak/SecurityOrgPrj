using System.Collections.Generic;

namespace SecurityOrgPrj.Data.Models
{
	public class Customer
	{
		public int CustomerId { get; set; }
		public string Customer_Name { get; set; }
		public string Custome_Surname { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public  int CityId { get; set; }


		public virtual ICollection<Subscription> Subscription { get; set; }


	}
}
