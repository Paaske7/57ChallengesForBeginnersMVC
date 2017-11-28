using System.Web.Mvc;
using Opgave_8.Models;

namespace Opgave_8.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Index(Propss prop)
        {

            if (ModelState.IsValid)
            {
                prop.each = (prop.Pizza * 8)/prop.People;

                prop.left = prop.Pizza % prop.each; 


                return View("Next", prop);
            }
            else
            {
                return View();
            }
        }
    }
}