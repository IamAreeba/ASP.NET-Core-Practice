using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
