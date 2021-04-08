using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Complaints
    {
       
        public int id { get; set; }
        [Required(ErrorMessage = "Reporting Date Required")]
        [Display(Name = "Reporting Date")]
        public string reporting_date { get; set; }
        [Required(ErrorMessage = "Status Required")]
        [Display(Name = "Province")]
        public int status_id { get; set; }
        [Required(ErrorMessage = "Complaint Type Required")]
        [Display(Name = "Complaint Type")]
        public int complaint_type_id { get; set; }
        [Required(ErrorMessage = "Description Required")]
        [Display(Name = "Description")]
        public string description { get; set; }
        
        [Display(Name = "Complaint Reported By")]
        public int owner { get; set; }
    }
}

