using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolApp.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment

        SchoolDB ADB = new SchoolDB();
        public ActionResult Index()
        {
            return View(ADB.Assignment.ToList());
        }

        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Assignments assignment)
        {
            if(ModelState.IsValid)
            {
                ADB.Assignment.Add(assignment);
                ADB.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}