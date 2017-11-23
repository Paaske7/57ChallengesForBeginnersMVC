using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opgave_4.Models;

namespace Opgave_4.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult StartPage()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StartPage(Words word)
        {
            if (ModelState.IsValid)
            {
                return View("Next", word);
            }
            else
            {
                return View();
            }
        }
    }
}