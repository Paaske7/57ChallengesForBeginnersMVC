using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opgave_7.Models;

namespace Opgave_7.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Index(Propertiess prop)
        {

            if (ModelState.IsValid)
            {
                prop.SquareFeet = prop.Length * prop.Width;
                prop.SquareMeters = prop.SquareFeet * 2; //Forkert regnestykke
               
                return View("Next",prop);
            }
            else
            {
                return View();
            }
        }
    }
}