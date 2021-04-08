using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Status
    {

        public int id { get; set; }
        [Required(ErrorMessage = "Status Name Required")]
        [Display(Name = "Staus Name")]
        public string name { get; set; }
    }
}
