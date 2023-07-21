using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ServiceController : Controller
    {

        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHobbies()
        {
            var values = context.Hobbies.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialGallerry()
        {
            var values = context.Galerries.ToList();
            return PartialView(values);
        }
    }
}