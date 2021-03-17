using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home/
        public ActionResult Index(int id = 0)
        {
            var nul = 0;
            ViewBag.Message = nul + "Your application description page." + id;
            return View();
        }
    }
}