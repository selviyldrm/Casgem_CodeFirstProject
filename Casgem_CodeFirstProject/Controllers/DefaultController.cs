using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSliderScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialBooking()
        {
            return PartialView();
        } 
        [HttpPost]
        public PartialViewResult PartialBooking(Booking booking)
        {
            travelContext.Bookings.Add(booking);
            booking.BookingStatus = "true";
            travelContext.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialDestinations()
        {
            var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            ViewBag.title1 = travelContext.Abouts.Select(x=>x.AboutTitle).FirstOrDefault();
            ViewBag.desc = travelContext.Abouts.Select(x=>x.AboutDescription).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialBookingCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            var values=travelContext.Galerries.Take(6).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMainScript()
        {
            return PartialView();
        }
    }
}