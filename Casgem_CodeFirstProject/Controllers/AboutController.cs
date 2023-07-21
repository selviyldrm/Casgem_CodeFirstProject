using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        TravelContext context = new TravelContext(); 
        public ActionResult Index()
        {
            return View();
        }
      public PartialViewResult PartialSliderScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialBreadcrumbs()
        {
            return PartialView();
        } 
        public PartialViewResult PartialAbout()
        {
            ViewBag.title = context.About2s.Select(x => x.Title).FirstOrDefault();
            ViewBag.desc = context.About2s.Select(x => x.Desc).FirstOrDefault();
            ViewBag.image = context.About2s.Select(x => x.ImageUrl).FirstOrDefault();

            return PartialView();
        }
        public PartialViewResult PartialTeams()
        {
            var values = context.Guides.Include("SocialMedia").ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
       
    }
}