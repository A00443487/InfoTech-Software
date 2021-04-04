using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Police
    {

        [Key]
        public int sin { get; set; }

        public int position_id { get; set; }
        public string activation_code {get; set;}
    }
}
