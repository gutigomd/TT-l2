using Microsoft.AspNetCore.Mvc;

namespace HotelMvcApp.Controllers
{
    public class ResolveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
