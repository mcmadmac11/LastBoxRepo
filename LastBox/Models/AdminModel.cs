using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastBox.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        internal virtual Role Role { get; set; }

    }
}