using HRP.Data;
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
        public IActionResult Police(RegisterVM  rVM)
        {
            rVM.user.is_police = "yes";
            return View();
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

            }
            else
            {
                var address_data = obj_HrpDbContext.Address.Add(rVM.address);
                obj_HrpDbContext.SaveChanges();
                var data = rVM.address;
                rVM.user.is_police = "no";
                rVM.user.address_id = rVM.address.id;
                var user_data = obj_HrpDbContext.Users.Add(rVM.user);

                var us_data = rVM.user;
            }

            return RedirectToAction("Login","Login");
        }
    }
}
