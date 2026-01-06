using Microsoft.AspNetCore.Mvc;

namespace ControllerImplementation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
