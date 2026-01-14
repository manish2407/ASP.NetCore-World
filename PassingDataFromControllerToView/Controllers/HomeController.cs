using Microsoft.AspNetCore.Mvc;
using PassingDataFromControllerToView.Models;
using System.Diagnostics;

namespace PassingDataFromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            /*
            //1. Use of ViewData to get the data from COntoller to View
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";
            Student student = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            //storing Student Data
            ViewData["Student"] = student;
            return View();*/

            /*
            //2. Use of ViewBag to get the data from COntoller to View
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";
            Student student = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };
            ViewBag.Student = student;
            return View();*/
            return View();


        }
    }
}
