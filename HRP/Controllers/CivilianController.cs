using HRP.Data;
using HRP.Models;
using HRP.ViewModels;
using iTextSharp.text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class CivilianController : Controller
    {
        private int sin;

        private HrpDbContext obj_hrpdbcontext;

        public CivilianController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }

        public void SessionCheck()
        {

            var session = HttpContext.Session.GetString("CivilianSessionId");
            
            if (session == null)
            {

                Response.Redirect(Url.Action("Login", "Login"));
            }
            else
            {
                sin = Int16.Parse(session);
            }
        }
        
        public IActionResult Index()
        {

            return RedirectToAction("ViewComplaints");
        }

        public IActionResult ViewComplaints()
        {
            SessionCheck();
            var data = sin;
            return View(obj_hrpdbcontext.Complaints.Where(data => data.owner == sin));
        }
        public IActionResult ComplaintCreate()
        {
            SessionCheck();
            ComplaintVM complaintvm = new ComplaintVM();
            complaintvm.status = obj_hrpdbcontext.Status.ToList();
            complaintvm.complainttype = obj_hrpdbcontext.Complaint_Types.ToList();
                                     
            return View(complaintvm);
        }
        [HttpPost]
        public IActionResult ComplaintCreated(string reporting_date, string status_id, string complaint_type_id, string code,string description)
        {
            SessionCheck();
            Complaints complaints = new Complaints();
            complaints.reporting_date = reporting_date;
           complaints.status_id = obj_hrpdbcontext.Status.Where(data => data.name == status_id).FirstOrDefault().id;
            complaints.complaint_type_id = obj_hrpdbcontext.Complaint_Types.Where(data => data.name == complaint_type_id).FirstOrDefault().id;
            complaints.description = description;
            complaints.owner = sin;
            obj_hrpdbcontext.Complaints.Add(complaints);
            obj_hrpdbcontext.SaveChanges();
            return RedirectToAction("ViewComplaints");
        }
        public IActionResult ViewMoreDetail(int id)
        {
            SessionCheck();
            ComplaintVM cvm = new ComplaintVM();
            cvm.complaints = obj_hrpdbcontext.Complaints.Where(data => data.id == id).FirstOrDefault();
            cvm.status_name =  obj_hrpdbcontext.Status.Where(data => data.id == cvm.complaints.status_id).FirstOrDefault().name;
            cvm.complaint_type_name = obj_hrpdbcontext.Complaint_Types.Where(data => data.id == cvm.complaints.complaint_type_id).FirstOrDefault().name;
            return View(cvm);
        }
        public IActionResult WithdrawComplaint()
        {
            SessionCheck();
            int status_id = obj_hrpdbcontext.Status.Where(data => data.name == "Withdraw").FirstOrDefault().id;
            
            return View(obj_hrpdbcontext.Complaints.Where(data => data.owner == sin && data.status_id != status_id));
        }
        [HttpPost]
        public IActionResult WithDrewComplaintPenalty(int id)
        {
            SessionCheck();
            Complaints comp = new Complaints();
            comp.id = id;
            return View(comp);
        }
        
        [HttpPost]
        public IActionResult WithDrewComplaint(int id,string cname, string ccnum, string exp, string cvv)
        {
            SessionCheck();
            int status_id = obj_hrpdbcontext.Status.Where(data => data.name == "Withdraw").FirstOrDefault().id;
            Complaints complaint = obj_hrpdbcontext.Complaints.Where(data => data.id == id).FirstOrDefault();
            complaint.status_id = status_id;
            obj_hrpdbcontext.Complaints.Update(complaint);
            obj_hrpdbcontext.SaveChanges();

            return RedirectToAction("ViewComplaints");
            
        }
        public IActionResult ReopenComplaint()
        {
            SessionCheck();
            int status_id_withdraw = obj_hrpdbcontext.Status.Where(data => data.name == "Withdraw").FirstOrDefault().id;
            int status_id_closed = obj_hrpdbcontext.Status.Where(data => data.name == "Closed").FirstOrDefault().id;

            return View(obj_hrpdbcontext.Complaints.Where(data => data.owner == sin && (data.status_id == status_id_withdraw || data.status_id == status_id_closed)));
        }

        [HttpPost]
        public IActionResult ReopendComplaint(int id)
        {
            SessionCheck();

            int status_id = obj_hrpdbcontext.Status.Where(data => data.name == "Reopen").FirstOrDefault().id;
            Complaints complaint = obj_hrpdbcontext.Complaints.Where(data => data.id == id).FirstOrDefault();
            complaint.status_id = status_id;
            obj_hrpdbcontext.Complaints.Update(complaint);
            obj_hrpdbcontext.SaveChanges();


            return RedirectToAction("ViewComplaints");
        }
        public IActionResult Logout()
        {
            SessionCheck();
            HttpContext.Session.Remove("CivilianSessionId");
            return this.RedirectToAction("Login", "Login");
        }


    }
}
