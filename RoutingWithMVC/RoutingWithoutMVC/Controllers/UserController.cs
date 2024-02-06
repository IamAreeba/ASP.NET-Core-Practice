using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
