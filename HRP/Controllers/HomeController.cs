using HRP.Data;
using HRP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class HomeController : Controller
    {
        // DO this
        private HrpDbContext obj_hrpdbcontext;
        //Do this
        public HomeController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }


        public IActionResult Index()
        {
            var address = obj_hrpdbcontext.Address.ToList();
            var admin = obj_hrpdbcontext.Admins.ToList();
            var users1 = obj_hrpdbcontext.Complaint_Handlers.ToList();
            var users2 = obj_hrpdbcontext.Complaints.ToList();
            var users3 = obj_hrpdbcontext.Complaint_Types.ToList();
            var users4 = obj_hrpdbcontext.Polices.ToList();
            var users5 = obj_hrpdbcontext.Status.ToList();
            var users = obj_hrpdbcontext.Users.ToList();
            var users6 = obj_hrpdbcontext.Positions.ToList();
            //var users = obj_hrpdbcontext.Admin.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
