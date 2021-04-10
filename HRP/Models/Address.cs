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
        [Required(ErrorMessage = "Door No Required")]
        [Display(Name = "Door Number")]
        public int door_no { get; set; }
        [Required(ErrorMessage = "Street Name Required")]
        [Display(Name = "Street Name")]
        public string street_name { get; set; }
        [Required(ErrorMessage = "Unit Name Required")]
        [Display(Name = "Unit")]
        public string unit { get; set; }
        [Required(ErrorMessage = "City Name Required")]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required(ErrorMessage = "Province Name Required")]
        [Display(Name = "Province")]
        public string province { get; set; }
        [Required(ErrorMessage = "Postal Code Required")]
        [Display(Name = "Postal Code")]
        public string postal_code { get; set; }
        [Required(ErrorMessage = "Country Name Required")]
        [Display(Name = "Country")]
        public string country { get; set; }
    }
}
    