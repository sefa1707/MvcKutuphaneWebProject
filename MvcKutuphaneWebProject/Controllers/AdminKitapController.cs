using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphaneWebProject.Controllers
{
    public class AdminKitapController : Controller
    {
        // GET: AdminKitap
        public ActionResult Index()
        {
            return View();
        }
    }
}