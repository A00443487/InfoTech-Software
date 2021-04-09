using HRP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.ViewModels
{
    public class RegisterVM
    {
        
        public User user { get; set; }

    public Police police { get; set; }
        public Address address { get; set; }
    }
}
