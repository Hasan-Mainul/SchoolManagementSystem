using SclManagementSystem.Data.Models;
using SclManagementSystem.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SclManagementSystem.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentData db;
        public StudentController(IStudentData db)
        {
            this.db = db;
        }
        // GET: Student
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("Not Found");
            }
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student) { 
       
        //    if (String.IsNullOrEmpty(student.Name))
        //    {
        //        ModelState.AddModelError(nameof(student.Name), "The name is Required");
        //    }
            if (ModelState.IsValid)
            {
                db.Add(student);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Update(student);
                return RedirectToAction("Index", new { id = student.ID });
            }
            return View(student);

        }
    }
}