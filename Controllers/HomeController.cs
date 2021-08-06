using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueryRenderingApp.Controllers
{
    public class HomeController : Controller
    { 
        //GET: Query
        public ActionResult Query()
        {
            ViewBag.Name = Request.QueryString["developer"];
            return View();
        }
    }
}