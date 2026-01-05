using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreEmptywithMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is Index action from MVC Controller";
        }
    }
}
