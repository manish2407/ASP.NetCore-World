using Microsoft.AspNetCore.Mvc;

namespace ControllerImplementation.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetAllStudents()
        {
            return "Return All Students";
        }
    }
}
