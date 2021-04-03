using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class User
    {
        //public int id { get; set; }
        [Key]
        public int sin { get; set; }

        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public char gender { get; set; }

        public DateTime dob { get; set; }

        public int address_id { get; set; }
        public string is_police { get; set; }

    }
}
