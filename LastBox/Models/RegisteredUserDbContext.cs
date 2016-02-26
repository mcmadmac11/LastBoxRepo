using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LastBox.Models
{
    public class RegisteredUserDbContext : DbContext
    {
        public RegisteredUserDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<SurveyModel> SurveyResponses { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<Box> Boxes { get; set; }
    }
}