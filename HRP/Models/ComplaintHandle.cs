using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class ComplaintHandle
    {

        public int id { get; set; }
        public int complaint_id { get; set; }

        public int officer_id { get; set; }
        public string last_update { get; set; }
    }
}
