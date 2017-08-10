using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendanceMark.Models;

namespace WebApplication2.Controllers
{

   
    public class HomeController : Controller
    {
       
        StudentAttendanceEntities db = new StudentAttendanceEntities();
        public ActionResult Index()
        {
            var listofstudents = db.Students.ToList();
            ViewBag.studentslist = listofstudents;
            return View();
        }


        
        [HttpPost]
        public ActionResult Create(Attendance markattendance, string markdate, int[] StudentId)
        {

            for (int i = 0; i < StudentId.Length; i++)
            {
                markattendance.SId = StudentId[i];
                markattendance.Date = markdate;
                db.Attendances.Add(markattendance);
                db.SaveChanges();
            }
          
            return Content("Attendance Marked..!!");
        } 
        
       
    }
}