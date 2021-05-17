﻿
using Microsoft.AspNetCore.Mvc;
using SecurityOrgPrj.Data.Interfaces;
using SecurityOrgPrj.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityOrgPrj.Data.repository
{
	public class SubscriptionRepository : IAllSubscriptions
	{
		
		private readonly AppDBContent appDbContent;

		public SubscriptionRepository(AppDBContent appDbContent)
		{
			this.appDbContent = appDbContent;
		}

		public List<Subscription> Subscriptions => appDbContent.Subscription.ToList();

		public void CreateSubscription(Subscription Subscription)
		{
			Subscription.StartSubscription = DateTime.Now;
			

			appDbContent.Subscription.Add(Subscription);

			appDbContent.SaveChanges();
		}

		public void RemoveSubscription()
		{
			appDbContent.Subscription.Remove(appDbContent.Subscription.OrderBy(x=>x.SubscriptionId).Last());
			appDbContent.SaveChanges();
		}
		
	}
}
