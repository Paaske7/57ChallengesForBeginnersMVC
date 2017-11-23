using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opgave3.Models;

namespace Opgave3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
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
        public ViewResult StartPage(Word word)
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