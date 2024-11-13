using Microsoft.AspNetCore.Mvc;
using MVCBooking.Models;

namespace MVCBooking.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> hotelBookings = new();
        public IActionResult Index()
        {
            return View(hotelBookings);
        }
        
        public IActionResult Create()
        {
            HotelBooking booking = new HotelBooking();
            return View(booking);
        }

        public IActionResult CreateBooking(HotelBooking booking)
        {
            hotelBookings.Add(booking);
            return RedirectToAction("Index");
        }
    }
}
