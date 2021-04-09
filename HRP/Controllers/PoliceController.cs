using HRP.Data;
using HRP.Models;
using HRP.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Controllers
{
    public class PoliceController : Controller
    {

        private HrpDbContext obj_hrpdbcontext;

        public PoliceController(HrpDbContext hrpdbcontext)
        {
            obj_hrpdbcontext = hrpdbcontext;
        }
        private int sin;
        public void SessionCheck()
        {

            var session = HttpContext.Session.GetString("PoliceSessionId");

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
            return View(obj_hrpdbcontext.Complaints);
        }

        public IActionResult ViewMoreDetail(int id)
        {
            SessionCheck();
            ComplaintVM cvm = new ComplaintVM();
            cvm.complaints = obj_hrpdbcontext.Complaints.Where(data => data.id == id).FirstOrDefault();
            cvm.status_name = obj_hrpdbcontext.Status.Where(data => data.id == cvm.complaints.status_id).FirstOrDefault().name;
            cvm.complaint_type_name = obj_hrpdbcontext.Complaint_Types.Where(data => data.id == cvm.complaints.complaint_type_id).FirstOrDefault().name;
            cvm.user = obj_hrpdbcontext.Users.Where(data => data.sin == cvm.complaints.owner).FirstOrDefault();
            cvm.address = obj_hrpdbcontext.Address.Where(data => data.id == cvm.user.address_id).FirstOrDefault();

            return View(cvm);
        }
        public IActionResult UpdateComplaintList()
        {
            SessionCheck();
            var data = obj_hrpdbcontext.Status.ToList().Where(x => !(x.name == "Withdraw") && !(x.name == "Closed"));
            int[] str = new int[20];
            int i = 0;
            foreach(Status s in data)
            {
                str[i] = s.id;
                i++;
            }
            

            return View(obj_hrpdbcontext.Complaints.Where(x=> str.Contains(x.status_id)));
        }
        
        [Route("update-complaint-status")]
              public IActionResult UpdateComplaintStatus(int id)
        {
            SessionCheck();
            ComplaintVM complaintVM = new ComplaintVM();
            
            
            var data = obj_hrpdbcontext.Status.ToList().Where(a => !(a.name == "Withdraw") && !(a.name == "Reopen") && !(a.name == "Closed") && !(a.name == "Case Filing Request"));

            complaintVM.status = new List<Status>();
            foreach (Status d in data)
            {
                Status s = new Status();
                s.name = d.name;
                complaintVM.status.Add(s);
            }
            complaintVM.complaints= obj_hrpdbcontext.Complaints.ToList().Where(x => x.id == id).FirstOrDefault();
            complaintVM.status_name = obj_hrpdbcontext.Status.Where(data => data.id == complaintVM.complaints.status_id).FirstOrDefault().name;
            complaintVM.complaint_type_name = obj_hrpdbcontext.Complaint_Types.Where(data => data.id == complaintVM.complaints.complaint_type_id).FirstOrDefault().name;
            
            


            return View(complaintVM);
        }

        [HttpPost]
        public IActionResult UpdatedComplaints(int id, string status, string code)
        {
            SessionCheck();

            int status_id = obj_hrpdbcontext.Status.Where(data => data.name == status).FirstOrDefault().id;
            Complaints complaint =obj_hrpdbcontext.Complaints.Where(x => x.id == id).FirstOrDefault();
            complaint.status_id = status_id;
            obj_hrpdbcontext.Complaints.Update(complaint);
            ComplaintHandle complaintHandle = new ComplaintHandle();
            complaintHandle.complaint_id = id;
            complaintHandle.officer_id = sin;
            complaintHandle.last_update = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            obj_hrpdbcontext.Complaint_Handlers.Add(complaintHandle);
            obj_hrpdbcontext.SaveChanges();


            return RedirectToAction("ViewComplaints");
        }
        public IActionResult ComplaintTrack()
        {
            SessionCheck();
            return View(obj_hrpdbcontext.Complaint_Handlers.Where(x => x.officer_id == sin));

        }
        public IActionResult Logout()
        {
            SessionCheck();
            HttpContext.Session.Remove("PoliceSessionId");
            return this.RedirectToAction("Login", "Login");
        }
    }
}
