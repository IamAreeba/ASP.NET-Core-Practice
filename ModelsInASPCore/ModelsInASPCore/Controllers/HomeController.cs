using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using System.Diagnostics;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var students = new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Areeba", Gender = "Female", Standard = "Final Year"},

                new StudentModel { rollNo = 2, Name = "Aiman", Gender = "Female", Standard = "Second Year"},

                new StudentModel { rollNo = 3, Name = "Ali", Gender = "Male", Standard = "Matric"},

                new StudentModel { rollNo = 4, Name = "Amjad", Gender = "Male", Standard = "Office"}
            };

            ViewData["myStudents"] = students;


            return View();
        }

        public IActionResult Privacy()
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
