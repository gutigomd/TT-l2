using Microsoft.AspNetCore.Mvc;

namespace HotelMvcApp.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult RoomDetails(string roomType = "Люкс «Панорама»")
        {
            ViewData["RoomTitle"] = roomType;
            return View();
        }
    }
}
