using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBone.Controllers
{
    public class MainController : Controller
    {
        public ActionResult MainIndex()
        {
            return View();
        }

        public ActionResult OpenContact()
        {
            return View("~/Views/Contact/ContactIndex.cshtml");
        }
    }
}