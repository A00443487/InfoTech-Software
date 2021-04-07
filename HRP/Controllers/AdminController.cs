using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRP.Models;
using HRP.Data;
using Microsoft.EntityFrameworkCore;
using HRP.ViewModels;
using Microsoft.AspNetCore.Http;

namespace HRP.Controllers
{
    
    public class AdminController : Controller
    {
       

        private HrpDbContext obj_hrpdbcontext;

        public AdminController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }

        public void SessionCheck()
        {
            
            var session = HttpContext.Session.GetString("AdminSessionId");
            if(session == null)
            {

                Response.Redirect(Url.Action("AdminLogin","Login"));
            }
        }
        [Route("admin-home")]
        public IActionResult Index()
        {
            SessionCheck();
            return View();
        }
        [Route("police-details")]
        public IActionResult PoliceList()
        {
            SessionCheck();
            return View(obj_hrpdbcontext.Polices);
        }
        [Route("police-creation")]
        public IActionResult PoliceCreate()
        {
            SessionCheck();
            return View(obj_hrpdbcontext.Positions);
        }
        [Route("error-ocured")]
        public IActionResult IdExist()
        {
            SessionCheck();
            return View("IdExist");
        }
        [HttpPost]
        public IActionResult PoliceCreated(int sin,string position, int activation_code)
        {
            SessionCheck();
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
            }catch(DbUpdateException )
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("PoliceList");
                
        }
        [HttpPost]
        public IActionResult PoliceDelete(int id)
        {
            SessionCheck();
            var police = obj_hrpdbcontext.Polices.Where(a => a.sin == id).FirstOrDefault();
            obj_hrpdbcontext.Polices.Remove(police);
            obj_hrpdbcontext.SaveChanges();
            return RedirectToAction("PoliceList");
        }

        [Route("police-update")]
        public IActionResult PoliceUpdate(int id)
        {
            SessionCheck();
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
            SessionCheck();
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
            catch (DbUpdateException )
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("PoliceList");

        }
        public IActionResult PositionList()
        {
            SessionCheck();
            return View(obj_hrpdbcontext.Positions);
        }
        public IActionResult PositionCreate()
        {
            SessionCheck();
            return View();
        }

        [HttpPost]
        public IActionResult PositionCreated(Position position)
        {
            SessionCheck();
            try
            {
                int exist = obj_hrpdbcontext.Positions.Count(x => x.name == position.name);
                if (exist > 0)
                {
                    throw new DbUpdateException();
                }
                else
                {
                    var data = obj_hrpdbcontext.Positions.Add(position);
                    obj_hrpdbcontext.SaveChanges();
                }
                
            }
            catch (DbUpdateException)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("PositionList");

        }

        [HttpPost]
        public IActionResult PositionDelete(int id)
        {
            SessionCheck();
            var position = obj_hrpdbcontext.Positions.Where(data => data.id == id).FirstOrDefault();
            obj_hrpdbcontext.Positions.Remove(position);
            obj_hrpdbcontext.SaveChanges();
            return RedirectToAction("PositionList");
        }

        
        public IActionResult PositionUpdate(int id)
        {


            SessionCheck();
            Position position = obj_hrpdbcontext.Positions.Where(data => data.id == id).FirstOrDefault();
            
            return View(position);
        }

        [HttpPost]

        public IActionResult PositionUpdated(Position position)
        {
            SessionCheck();
            try
            {
                int exist = obj_hrpdbcontext.Positions.Count(x => x.name == position.name);
                if (exist > 0)
                {
                    throw new DbUpdateException();
                }
                else
                {
                    var updatequery = obj_hrpdbcontext.Positions
              .Where(x => x.id == position.id)
              .FirstOrDefault();
                    updatequery.name = position.name;
                    obj_hrpdbcontext.SaveChanges();
                        
                }

            }
            catch (DbUpdateException)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("PositionList");
        }
        
        public IActionResult StatusList()
        {
            SessionCheck();
            return View(obj_hrpdbcontext.Status);
        }
        public IActionResult StatusCreate()
        {
            SessionCheck();
            return View();
        }

        [HttpPost]
        public IActionResult StatusCreated(Status status)
        {
            SessionCheck();

            try
            {
                int exist = obj_hrpdbcontext.Status.Count(x => x.name == status.name);
                if (exist > 0)
                {
                    throw new DbUpdateException();
                }
                else
                {
                    obj_hrpdbcontext.Status.Add(status);
                    obj_hrpdbcontext.SaveChanges();
                }

            }
            catch (DbUpdateException)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("StatusList");

        }

        [HttpPost]
        public IActionResult StatusDelete(int id)
        {
            SessionCheck();
            var status = obj_hrpdbcontext.Status.Where(data => data.id == id).FirstOrDefault();
            obj_hrpdbcontext.Status.Remove(status);
            obj_hrpdbcontext.SaveChanges();
            return RedirectToAction("StatusList");
        }

        //PENDING
        public IActionResult StatusUpdate(int id)
        {


            SessionCheck();

            Status status = obj_hrpdbcontext.Status.Where(data => data.id == id).FirstOrDefault();

            return View(status);
        }

        [HttpPost]

        public IActionResult StatusUpdated(Status status)
        {
            SessionCheck();
            try
            {
                int exist = obj_hrpdbcontext.Status.Count(x => x.name == status.name);
                if (exist > 0)
                {
                    throw new DbUpdateException();
                }
                else
                {
                    var updatequery = obj_hrpdbcontext.Status
              .Where(x => x.id == status.id)
              .FirstOrDefault();
                    updatequery.name = status.name;
                    obj_hrpdbcontext.SaveChanges();

                }

            }
            catch (DbUpdateException)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("StatusList");
        }
        
        public IActionResult ComplaintTypeList()
        {
            SessionCheck();
            return View(obj_hrpdbcontext.Complaint_Types);
        }
        public IActionResult ComplaintTypeCreate()
        {
            SessionCheck();
            return View();
        }

        [HttpPost]
        public IActionResult ComplaintTypeCreated(ComplaintType complainttype)
        {
            SessionCheck();
            try
            {
                int exist = obj_hrpdbcontext.Complaint_Types.Count(x => x.name == complainttype.name);
                if (exist > 0)
                {
                    throw new DbUpdateException();
                }
                else
                {
                    obj_hrpdbcontext.Complaint_Types.Add(complainttype);
                    obj_hrpdbcontext.SaveChanges();
                }

            }
            catch (DbUpdateException)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("ComplaintTypeList");

        }

        [HttpPost]
        public IActionResult ComplaintTypeDelete(int id)
        {
            SessionCheck();
            var complainttype = obj_hrpdbcontext.Complaint_Types.Where(data => data.id == id).FirstOrDefault();
            obj_hrpdbcontext.Complaint_Types.Remove(complainttype);
            obj_hrpdbcontext.SaveChanges();
            return RedirectToAction("ComplaintTypeList");
        }

        //PENDING
        public IActionResult ComplaintTypeUpdate(int id)
        {



            SessionCheck();
            ComplaintType complainttype = obj_hrpdbcontext.Complaint_Types.Where(data => data.id == id).FirstOrDefault();

            return View(complainttype);
        }

        [HttpPost]

        public IActionResult ComplaintTypeUpdated(ComplaintType complainttype)
        {
            SessionCheck();
            try
            {
                int exist = obj_hrpdbcontext.Complaint_Types.Count(x => x.name == complainttype.name);
                if (exist > 0)
                {
                    throw new DbUpdateException();
                }
                else
                {
                    var updatequery = obj_hrpdbcontext.Complaint_Types
              .Where(x => x.id == complainttype.id)
              .FirstOrDefault();
                    updatequery.name = complainttype.name;
                    obj_hrpdbcontext.SaveChanges();

                }

            }
            catch (DbUpdateException)
            {
                return RedirectToAction("IdExist");
            }
            return RedirectToAction("ComplaintTypeList");
        }
        public IActionResult Profile()
        {


            SessionCheck();
            var username = HttpContext.Session.GetString("AdminSessionId");
            
            return View(obj_hrpdbcontext.Admins.Where(data => data.username == username).FirstOrDefault());
        }
        public IActionResult PasswordUpdate()
        {
            return View();
        }

        [HttpPost]

        public IActionResult PasswordUpdated(string pswd, string cpswd)
        {
            SessionCheck();
            
                    var updatequery = obj_hrpdbcontext.Admins
              .Where(x => x.username == HttpContext.Session.GetString("AdminSessionId"))
              .FirstOrDefault();
            updatequery.password = pswd;
                    obj_hrpdbcontext.SaveChanges();

            
            return RedirectToAction("Index");
        }
        public IActionResult Logout()
        {

            HttpContext.Session.Remove("AdminSessionId");
            return this.RedirectToAction("AdminLogin", "Login");
        }

    }
}
