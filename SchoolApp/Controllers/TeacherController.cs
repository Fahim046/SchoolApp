using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        SchoolDB TDB = new SchoolDB();
        public ActionResult Index()
        {
            return View(TDB.Teacher.ToList());
        }

        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Teachers teacher)
        {
            if (ModelState.IsValid)
            {
                TDB.Teacher.Add(teacher);
                TDB.SaveChanges();
            }

            return RedirectToAction("Index");
        }




    }
}