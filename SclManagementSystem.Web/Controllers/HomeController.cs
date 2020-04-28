using SclManagementSystem.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SclManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        IStudentData db;
        public HomeController()
        {
            db = new InMemoryStudentData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(db);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}