using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        public static List<Course> CoursesDB = new();
        public static List<Student> StudentsDB = new();
        public static Dictionary<string, List<UInt64>> EnrollmentsDB = new();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}