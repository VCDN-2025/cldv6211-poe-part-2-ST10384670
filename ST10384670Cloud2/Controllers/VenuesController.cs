using Microsoft.AspNetCore.Mvc;

namespace ST10384670Cloud2.Controllers
{
    public class VenuesController : Controller
    {
        public IActionResult Index()
        {
            return View(); // This looks for Views/Venues/Index.cshtml
        }
    }
}
