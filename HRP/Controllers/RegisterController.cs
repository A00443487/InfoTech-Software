using HRP.Data;
using HRP.Models;
using HRP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class RegisterController : Controller
    {
        private HrpDbContext obj_HrpDbContext;
        public RegisterController(HrpDbContext hrp)
        {
            obj_HrpDbContext = hrp;
        }
        
        [Route("police")]
        public IActionResult Police()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult PoliceRegister(RegisterVM rVM)
        {



            Police police = obj_HrpDbContext.Polices.Where(x => x.sin == rVM.user.sin).FirstOrDefault();

            if (police == null)
            {
                return View("Error");
            }

            bool is_exist = obj_HrpDbContext.Users.Where(x => x.sin == rVM.user.sin).Any();

            if (is_exist)
            {
                return RedirectToAction("Login", "Login");
            }

            var activation_code = Convert.ToString(rVM.police.activation_code);
            var d = police.activation_code;
            
            if ( activation_code == police.activation_code)
            {
                var address_data = obj_HrpDbContext.Address.Add(rVM.address);
                obj_HrpDbContext.SaveChanges();
                var data = rVM.address;
                rVM.user.is_police = "yes";
                rVM.user.address_id = rVM.address.id;
                var user_data = obj_HrpDbContext.Users.Add(rVM.user);
                obj_HrpDbContext.SaveChanges();
                var us_data = rVM.user;
                return RedirectToAction("Login", "Login");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid Activation Code";
                return RedirectToAction("Police");
            }

            
        }


        [Route("civillian")]

        public IActionResult Civilian()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Civilian(RegisterVM rVM)
        {

          bool is_exist_user=  obj_HrpDbContext.Users.Where(u => u.sin == rVM.user.sin).Any();
            if (is_exist_user)
            {
                return RedirectToAction("Login","Login");
            }
            else
            {
                var address_data = obj_HrpDbContext.Address.Add(rVM.address);
                obj_HrpDbContext.SaveChanges();
                var data = rVM.address;
                rVM.user.is_police = "no";
                rVM.user.address_id = rVM.address.id;
                var user_data = obj_HrpDbContext.Users.Add(rVM.user);
                obj_HrpDbContext.SaveChanges();
                var us_data = rVM.user;
            }

            return RedirectToAction("Login","Login");
        }
    }
}
