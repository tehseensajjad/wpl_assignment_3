using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View(HomeController.CoursesDB);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection data)
        {
            HomeController.CoursesDB.Add(
                new Course
                {
                    Code = data["code"],
                    Title = data["title"],
                    Teacher = data["teacher"]
                });
            return RedirectToAction("Index");
        }

        public IActionResult Remove(string code)
        {
            HomeController.CoursesDB.RemoveAll(c => c.Code == code);
            return View("Index", HomeController.CoursesDB);
        }
    }
}
