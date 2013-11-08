using MVC5RawUrlProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5RawUrlProblem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult 登入()
        {
            return View();
        }

        [HttpPost]
        public ActionResult 登入(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {

                //return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}