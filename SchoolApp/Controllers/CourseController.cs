using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class CourseController : Controller
    {

        SchoolDB CDB = new SchoolDB();             
        
        // GET: Course
        public ActionResult Index() 
        {
           // a.Assignments.Add();
            return View(CDB.Course.ToList()); // Goes to Views -> search for Course -> return Index ....
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SchoolApp.Models.Courses course)
        {
            if (ModelState.IsValid)
            {
                CDB.Course.Add(course);
                CDB.SaveChanges();

                //People.DbPeople.Add(people);


            }
                return RedirectToAction("Index");

            

        }




    }
}