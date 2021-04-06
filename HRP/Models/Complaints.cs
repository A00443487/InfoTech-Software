using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class Complaints
    {
        public string status_name = "";
        public string complaint_type_name ="";
        public int id { get; set; }

        public DateTime reporting_date { get; set; }

        public int status_id { get; set; }

        public int complaint_type_id { get; set; }

        public string description { get; set; }

        public int owner { get; set; }
    }
}
