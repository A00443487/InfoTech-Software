using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT = System.Data;
using QC = System.Data.SqlClient;

namespace HalifaxRegionalPolice.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            
                return View();
            


        }
    }
}