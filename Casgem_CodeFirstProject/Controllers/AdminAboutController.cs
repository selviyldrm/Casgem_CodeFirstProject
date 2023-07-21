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
    public class AdminAboutController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values=travelContext.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            travelContext.Abouts.Add(about);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            var values=travelContext.Abouts.Find(id);
            travelContext.Abouts.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = travelContext.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateGuide(About about)
        {
            var value = travelContext.Abouts.Find(about.AboutID);
            value.AboutTitle = about.AboutTitle;
            value.AboutDescription = about.AboutDescription;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}