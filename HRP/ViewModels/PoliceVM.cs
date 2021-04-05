using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRP.Models;

namespace HRP.ViewModels
{
    public class PoliceVM
    {
        public List<Position> positions { get; set; }
        public string position_name;
        public Police police { get; set; }
    }
}
