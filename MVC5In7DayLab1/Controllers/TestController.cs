using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5In7DayLab1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult demo()
        {
            return View();
        }

        public string GetString()
        {
            return "Hello!";
        }
    }
}