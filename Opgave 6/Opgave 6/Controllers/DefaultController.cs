using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opgave_6.Models;

namespace Opgave_6.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public ViewResult StartPage()
        {

            return View();
        }

        [HttpPost]
        public ViewResult StartPage(Ages ag)
        {

            if (ModelState.IsValid)
            {
                ag.dt = DateTime.Now;

                ag.left = ag.RetireAge - ag.Age;

                ag.dt2 = ag.dt.AddYears(ag.left);

                 
                return View("Next",ag);
            }
            else
            {
                return View();
            }
        }
    }
}