using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LastBox.Models
{
    public class UserSubscription
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SubscriptionCost { get; set; }
        public decimal TotalSubscriptionCost { get; set; }
    }
}