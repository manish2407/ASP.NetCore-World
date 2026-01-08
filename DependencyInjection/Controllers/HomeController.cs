using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        // Without Dependency Injection
        /*public JsonResult Index()
        {
            StudentRepository repository = new StudentRepository();
            List<Student> allStudentDetails = repository.GetAllStudent();
            return Json(allStudentDetails);
        }
        public JsonResult GetStudentDetails(int Id)
        {
            StudentRepository repository = new StudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }*/

        /* // Constructor Dependency Injection
        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository? _repository = null;
        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Index()
        {
            List<Student>? allStudentDetails = _repository?.GetAllStudent();
            return Json(allStudentDetails);
        }
        public JsonResult GetStudentDetails(int Id)
        {
            Student? studentDetails = _repository?.GetStudentById(Id);
            return Json(studentDetails);
        }*/


        /*// Method Dependency Injection
        public JsonResult Index([FromServices] IStudentRepository repository)
        {
            List<Student> allStudentDetails = repository.GetAllStudent();
            return Json(allStudentDetails);
        }*/


    }
}
