using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastBox.Models
{
    public class BoxContents
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public BoxContents(string name)
        {
            this.Name = name;
        }
    }
}