using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.Interfaces
{
	public interface IAllSubscriptions
	{
		void CreateSubscription(Subscription Subscription);
		public List<Subscription> Subscriptions { get; }
		void RemoveSubscription(Subscription Subscription);
		void EditSubscription(Subscription Subscription);
	}
}
