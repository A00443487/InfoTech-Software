using HRP.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class ComplaintController : Controller
    {
        private HrpDbContext obj_hrpdbcontext;


        public ComplaintController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }

        [Route("complaint-controller")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
