using Microsoft.AspNetCore.Mvc;

namespace YourProjectName.Controllers
{
    public class BookingsController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
