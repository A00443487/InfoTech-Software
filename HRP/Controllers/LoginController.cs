using HRP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRP.Data;
namespace HRP.Controllers
{
    public class LoginController : Controller
    {
        private HrpDbContext obj_hrpdbcontext;

        public LoginController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminLogin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var entry = obj_hrpdbcontext.Admins.Count(a => a.username == admin.username && a.password == admin.password);
                if (entry > 0)
                {
                    return this.RedirectToAction("Index","Admin");
                }
                else
                {
                    ViewBag.ErrorMessage = "UserName or Password is wrong";
                    return View("AdminLogin");
                }

            }

          return View("AdminLogin");
         

        }



        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var entry = obj_hrpdbcontext.Admins.Count(a => a.username == admin.username && a.password == admin.password);
                if (entry > 0)
                {
                    return this.RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.ErrorMessage = "UserName or Password is wrong";
                    return View("AdminLogin");
                }

            }

            return View("AdminLogin");


        }
    }
}
