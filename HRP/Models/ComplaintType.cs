using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class ComplaintType
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Complaint Type Required")]
        [Display(Name = "Complaint Type Name")]
        public string name { get; set; }
    }
}
