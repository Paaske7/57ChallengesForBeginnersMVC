using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opgave_5.Models;

namespace Opgave_5.Controllers
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
        public ViewResult StartPage(Numbers no)
        {
            
            if (ModelState.IsValid)
            {
                no.result1 = no.Number1 + no.Number2;
                no.result2 = no.Number1 - no.Number2;
                no.result3 = no.Number1 * no.Number2;
                no.result4 = no.Number1 / no.Number2;
                return View("Next", no);
            }
            else
            {
                return View();
            }
        }
    }
}