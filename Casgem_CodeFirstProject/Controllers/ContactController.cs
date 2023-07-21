using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        TravelContext context = new TravelContext();
        [HttpGet]
        public ActionResult Index()
        { 
            return View();
        } 
        [HttpPost]
        public ActionResult Index(Contact c)
        
        { context.Contacts.Add(c);
            c.MessageDate = DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PartialContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialBreadcrumb()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}

//mesaj gönderme yapılacak