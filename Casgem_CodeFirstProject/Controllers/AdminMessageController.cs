using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminMessageController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Contacts.ToList();
            return View(values);
        }
        public ActionResult MessageDetails(int id)
        {
            var values = travelContext.Contacts.Find(id);
            return View(values);
        }public ActionResult DeleteMessage(int id)
        {
            var values = travelContext.Contacts.Find(id);
            travelContext.Contacts.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}