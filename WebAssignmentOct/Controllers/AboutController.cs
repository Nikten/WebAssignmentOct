using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAssignmentOct.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult educatuation()
        {
            return View();
        }

        public ActionResult Exprience()
        {
            return View();
        }
        
        public ActionResult Knolege()
        {
            return View();
        }
    }
}