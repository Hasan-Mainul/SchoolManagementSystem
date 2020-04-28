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
    }
}