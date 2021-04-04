using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Admin
    {
        [Key]
        public int sin { get; set; }
        [Required(ErrorMessage = "Please enter your username.")]
        [Display(Name = "Username")]
        
        public string username { get; set; }
        
        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }


    }
}
