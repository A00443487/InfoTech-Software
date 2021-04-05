using HRP.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class PoliceController : Controller
    {

        private HrpDbContext obj_hrpdbcontext;


        public PoliceController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewComplaint()
        {
            return View();
        }
        public IActionResult UpdateComplaint()
        {
            return View();
        }
        public String Profile()
        {
            return "Don't know if requried: Logout";
        }
        public String Logout()
        {
            return "Don't know if requried : Logout";
        }
    }
}
