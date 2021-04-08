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
        [Required(ErrorMessage = "SIN Required")]
        [Display(Name = "Social Insurance Number")]
        public int sin { get; set; }
        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "First Name")]
        public string fname { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Required(ErrorMessage = "Email ID Required")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }
        [Required(ErrorMessage = "Contact Required")]
        [Display(Name = "Contact")]
        public string contact { get; set; }
        [Required(ErrorMessage = "Gender Required")]
        [Display(Name = "Gender")]
        public char gender { get; set; }
        [Required(ErrorMessage = "DOB Required")]
        [Display(Name = "Date Of Birth")]
        public DateTime dob { get; set; }

        public int address_id { get; set; }
        public string is_police { get; set; }

    }
}
