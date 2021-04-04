using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Admin
    {
        [Key]
        public int sin { get; set; }
        public string username { get; set; }
        public string password { get; set; }


    }
}
