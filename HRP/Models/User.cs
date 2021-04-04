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
        [Required]
        [Display(Name = "SIN")]
        public int sin { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string fname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Required]
        [Display(Name = "Contact")]
        public string contact { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public char gender { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime dob { get; set; }

        public int address_id { get; set; }
        public string is_police { get; set; }

    }
}
