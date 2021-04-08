using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Police
    {

        [Key]
        [Display(Name = "SIN")]
        public int sin { get; set; }
        
        [Display(Name = "Position ID")]
        public int position_id { get; set; }
        [Required(ErrorMessage ="Activation Code Required")]
        [Display(Name = "Activation Code")]
        public string activation_code {get; set;}
    }
}
