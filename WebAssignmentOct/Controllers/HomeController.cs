using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAssignmentOct.Controllers
{
    public class HomeController : Controller
    {


        WebDataBaseEntities MyInfo = new WebDataBaseEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View(MyInfo);
        }

        public ActionResult Contacts()
        {
            return View();
        }
    }
}