using ControllerImplementation.Models;
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
        public JsonResult GetStudentDetails(int Id)
        {
            StudentRepository repository = new StudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
