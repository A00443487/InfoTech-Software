using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRP.Models;
using HRP.Data;
using Microsoft.EntityFrameworkCore;
using HRP.ViewModels;

namespace HRP.Controllers
{
    public class AdminController : Controller
    {
       

        private HrpDbContext obj_hrpdbcontext;

        public AdminController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }

        //PoliceDataAccessLayer police_dal = new PoliceDataAccessLayer(obj_hrpdbcontext);
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PoliceList()
        {
            
            return View(obj_hrpdbcontext.Polices);
        }

        public IActionResult PoliceCreate()
        {

            return View(obj_hrpdbcontext.Positions);
        }
        public IActionResult IdExist()
        {

            return View("IdExist");
        }
        [HttpPost]
        public IActionResult PoliceCreated(int sin,string position, int activation_code)
        {
            Police police = new Police();
            var data = obj_hrpdbcontext.Positions.ToList().Where(x => x.name == position);
            foreach (Position d in data )
            {
                police.position_id = d.id;
            }

            police.sin = sin;
            police.activation_code = Convert.ToString(activation_code);
            try
            {
                obj_hrpdbcontext.Polices.Add(police);
                obj_hrpdbcontext.SaveChanges();
            }catch(DbUpdateException dbexception)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("PoliceList");
                
        }
        [HttpPost]
        public IActionResult PoliceDelete(int id)
        {
            var police = obj_hrpdbcontext.Polices.Where(a => a.sin == id).FirstOrDefault();
            obj_hrpdbcontext.Polices.Remove(police);
            obj_hrpdbcontext.SaveChanges();
            return RedirectToAction("PoliceList");
        }

        public IActionResult PoliceUpdate(int id)
        {
            PoliceVM policevm = new PoliceVM();
            List<Position> position =obj_hrpdbcontext.Positions.ToList();

            Police police = obj_hrpdbcontext.Polices.Where(a => a.sin == id).FirstOrDefault();
            var data = obj_hrpdbcontext.Positions.ToList().Where(x => x.id == police.position_id);
            foreach (Position d in data)
            {
                policevm.position_name = d.name;
            }
            
            
            policevm.police = police;
            policevm.positions = position;

            return View(policevm);
        }

        [HttpPost]
        
        public IActionResult PoliceUpdated(int sin, string position, int activation_code)
        {
            var sin1 = sin;

            Police police = new Police();
            var data = obj_hrpdbcontext.Positions.ToList().Where(x => x.name == position);
            foreach (Position d in data)
            {
                police.position_id = d.id;
            }

            police.sin = sin;
            police.activation_code = Convert.ToString(activation_code);
            try
            {
                obj_hrpdbcontext.Polices.Update(police);
                obj_hrpdbcontext.SaveChanges();
            }
            catch (DbUpdateException dbexception)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("PoliceList");

        }




    }
}
