using HRP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRP.Data;
using Microsoft.AspNetCore.Http;

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
                    HttpContext.Session.SetString("AdminSessionId", admin.username);
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

        [HttpPost]
        public IActionResult Login(User user)
        {
            
            var check = obj_hrpdbcontext.Polices.Count(a => a.sin == user.sin);
            if(check > 0)
            {
                var entry = obj_hrpdbcontext.Users.Count(a => a.sin == user.sin && a.password == user.password);
                if (entry > 0)
                {
                    HttpContext.Session.SetString("PoliceSessionId",  user.sin.ToString());
                    return this.RedirectToAction("Index", "Police");
                }
                else
                {
                    ViewBag.ErrorMessage = "UserName or Password is wrong";
                    return View("Login");
                }

            }
            else
            {
                    var entry = obj_hrpdbcontext.Users.Count(a => a.sin == user.sin && a.password == user.password);
                    if (entry > 0)
                {
                    HttpContext.Session.SetString("CivilianSessionId", user.sin.ToString());
                    return this.RedirectToAction("Index", "Civilian");
                }
                else
                {
                    ViewBag.ErrorMessage = "UserName or Password is wrong";
                    return View("Login");
                }
            }
        }

        
        public IActionResult Login()
        {
            return View();
        }

    }
}
