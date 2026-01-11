using Microsoft.AspNetCore.Mvc;
using TypesOfServicesInCore.Models;

namespace TypesOfServicesInCore.Controllers
{
    public class HomeController : Controller
    {
        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository? _repository = null;
        private readonly SomeOtherService? _someOtherService = null;
        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository, SomeOtherService someOtherService)
        {
            _repository = repository;
            _someOtherService = someOtherService;
        }
        public JsonResult Index()
        {
            List<Student>? allStudentDetails = _repository?.GetAllStudent();
            _someOtherService?.SomeMethod();
            return Json(allStudentDetails);
        }
        public JsonResult GetStudentDetails(int Id)
        {
            Student? studentDetails = _repository?.GetStudentById(Id);
            _someOtherService?.SomeMethod();
            return Json(studentDetails);
        }
    }
}
