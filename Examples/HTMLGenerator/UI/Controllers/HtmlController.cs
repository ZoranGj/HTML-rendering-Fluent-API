using API.Infrastructure;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HtmlController : Controller
    {
        private readonly Engine _engine;
        private readonly DataEngine _dataEngine;

        public HtmlController()
        {
            _engine = new Engine();
            _dataEngine = new DataEngine();
        }

        public ActionResult Form()
        {
            var model = _engine.ExampleForm();
            return View((object)model);
        }

        public ActionResult MultipleForms()
        {
            var model = _engine.ExampleMultipleForms();
            return View((object)model);
        }

        public ActionResult DataForm()
        {
            var model = _dataEngine.GenerateForm(1);
            return View(model);
        }

        public ActionResult DataTable()
        {
            var model = _dataEngine.GenerateTable(1);
            return View(model);
        }
    }
}