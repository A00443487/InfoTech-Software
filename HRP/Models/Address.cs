using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Address
    {
        public int id { get; set; }

        public int door_no { get; set; }

        public string street_name { get; set; }
        public string unit { get; set; }

        public string city { get; set; }

        public string province { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }
}
