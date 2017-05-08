using API;
using API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private Engine _engine;

        public HomeController()
        {
            _engine = new Engine();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}