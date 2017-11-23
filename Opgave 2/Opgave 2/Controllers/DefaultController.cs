using Opgave_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Opgave_2.Controllers
{
    public class DefaultController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult StartPage()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StartPage(Word str)
        {
            if (ModelState.IsValid)
            {
                return View("Result", str);
            }
            else
            {
                return View();
            }
        }
    }
}