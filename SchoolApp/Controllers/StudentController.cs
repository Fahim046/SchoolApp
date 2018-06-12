using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        SchoolDB SDB = new SchoolDB();

        public ActionResult Index()
        {
            return View(SDB.Student.ToList());
        }


        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Students student)
        {
            if (ModelState.IsValid)
            {
                SDB.Student.Add(student);
                SDB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}