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
        [Required(ErrorMessage = "Please enter your position name.")]
        [Display(Name = "Position Name")]
        public string name { get; set; }
    }
}
