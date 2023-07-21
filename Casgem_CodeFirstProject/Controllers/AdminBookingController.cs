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
    public class AdminBookingController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Bookings.ToList();
            return View(values);
        }
        public ActionResult DeleteBooking(int id)
        {
            var values = travelContext.Bookings.Find(id);
            travelContext.Bookings.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult UpdateBooking(int id)
        {
            var values = travelContext.Bookings.Find(id);
            return View(values);
        }
        [HttpPost]

        public ActionResult UpdateBooking(Booking booking)
        {
            var values = travelContext.Bookings.Find(booking.BookingID);
            values.CustomerName = booking.CustomerName;
            values.Mail = booking.Mail;
            values.Destination = booking.Destination;
            values.Duration = booking.Duration;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}