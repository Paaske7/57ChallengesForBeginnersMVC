using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
// Mikael
namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Welcome()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Welcome(Class1 klasse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks",klasse);
            }
            else
            {
                return View();
            }
        }
    }
}