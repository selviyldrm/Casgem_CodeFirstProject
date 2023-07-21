using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminServiceController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var values = context.Hobbies.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult AddService(Hobbies hobbies)
        {
            context.Hobbies.Add(hobbies);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
           var value=context.Hobbies.Find(id);
            context.Hobbies.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = context.Hobbies.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Hobbies hobbies)
        {
            var value = context.Hobbies.Find(hobbies.HobbiesID);
           value.Title = hobbies.Title;
            value.Icon = hobbies.Icon;
            value.Description = hobbies.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}