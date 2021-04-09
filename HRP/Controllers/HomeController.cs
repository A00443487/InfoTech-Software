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

        public IActionResult Index()
        {
            
            return View();
        }
       


    }
}
