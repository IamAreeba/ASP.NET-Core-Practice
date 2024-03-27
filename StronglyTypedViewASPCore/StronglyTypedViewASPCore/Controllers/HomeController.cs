using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;
using System.Diagnostics;

namespace StronglyTypedViewASPCore.Controllers
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
            //Employee obj = new Employee()
            //{
            //    Id = 101,
            //    Name = "Areeba",
            //    Designation = "Manager",
            //    Salary = 9000000
            //};



            // Making List of Employees
            var myEmployee = new List<Employee>()
            {
                new Employee{ Id = 101, Name = "Areeba", Designation = "Manager", Salary = 900000},
                new Employee{ Id = 102, Name = "Aiman", Designation = "Accountant", Salary = 900000},
                new Employee{ Id = 103, Name = "Shazia", Designation = "Assistant", Salary = 900000},
                new Employee{ Id = 104, Name = "Tooba", Designation = "Operator", Salary = 900000},
            };

            return View(myEmployee);
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
