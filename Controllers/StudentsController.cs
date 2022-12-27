using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View(HomeController.StudentsDB);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection data)
        {
            HomeController.StudentsDB.Add(
                new Student
                {
                    RollNumber = UInt64.Parse(data["rollnum"]),
                    FirstName = data["fname"],
                    LastName = data["lname"]
                });
            return RedirectToAction("Index");
        }
        public IActionResult Remove(string rollnum)
        {
            var target = UInt64.Parse(rollnum);
            HomeController.StudentsDB.RemoveAll(s => s.RollNumber == target);
            return View("Index", HomeController.StudentsDB);
        }
    }
}
