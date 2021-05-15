using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.Models
{
	public class Staff
	{
		public int StaffId { get; set; }
		[Required]
		public string NameCommand { get; set; }
		[Required]
		public int CountPeople { get; set; }

		public virtual ICollection<DeparutureInfo> DeparutureInfo { get; set; }
	}
}
