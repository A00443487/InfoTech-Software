using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Address
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Door Number")]
        public int door_no { get; set; }
        [Required]
        [Display(Name = "Street Name")]
        public string street_name { get; set; }
        [Required]
        [Display(Name = "Unit")]
        public string unit { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [Display(Name = "Province")]
        public string province { get; set; }
        [Required]
        [Display(Name = "Postal COde")]
        public string postal_code { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string country { get; set; }
    }
}
