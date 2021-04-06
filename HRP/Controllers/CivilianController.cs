using HRP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class CivilianController : Controller
    {
        public int sin;

        private HrpDbContext obj_hrpdbcontext;

        public CivilianController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }
        public IActionResult Index()
        {
            sin = Int16.Parse(HttpContext.Session.GetString("CivilianSessionId"));
            return View();
        }
        public IActionResult ViewComplaints()
        {
         
            return View(obj_hrpdbcontext.Complaints.Where(data => data.owner == sin));
        }
        public IActionResult ComplaintCreate()
        {
            
            return View(obj_hrpdbcontext.Positions);
        }
        


    }
}
