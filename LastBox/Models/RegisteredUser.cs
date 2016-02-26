using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LastBox.Models
{
    public class RegisteredUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ShippingAddress { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Current Subscriptions")]
        public ICollection<Box> CurrentBoxSubscriptions { get; set; }
    }
}