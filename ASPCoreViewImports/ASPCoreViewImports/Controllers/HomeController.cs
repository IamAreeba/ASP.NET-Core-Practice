using ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{ Id = 1, Name="Areeba", Gender="Female"},
                new Student{ Id = 2, Name = "Aiman", Gender = "Female"},
                new Student{ Id = 3, Name = "Shazia", Gender = "Female"}
            };


            return View(students);
        }

        public IActionResult About()
        {

            List<Student> students = new List<Student>
            {
                new Student{ Id = 1, Name="Areeba", Gender="Female"},
                new Student{ Id = 2, Name = "Aiman", Gender = "Female"},
                new Student{ Id = 3, Name = "Shazia", Gender = "Female"}
            };
            return View(students);
        }

        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student{ Id = 1, Name="Areeba", Gender="Female"},
                new Student{ Id = 2, Name = "Aiman", Gender = "Female"},
                new Student{ Id = 3, Name = "Shazia", Gender = "Female"}
            };
            return View(students);
        }
    }
}
