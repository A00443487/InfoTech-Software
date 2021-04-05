using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Complaints
    {
        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Reporting Date")]
        public DateTime reporting_date { get; set; }

        [Display(Name = "Status ID")]
        public int status_id { get; set; }

        [Display(Name = "Complaint Type")]
        public int complaint_type_id { get; set; }



        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Owner")]
        public int owner { get; set; }
    }
}
