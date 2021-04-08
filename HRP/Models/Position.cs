using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Position
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Position Name Required")]
        [Display(Name = "Position Name")]
        public string name { get; set; }
    }
}
