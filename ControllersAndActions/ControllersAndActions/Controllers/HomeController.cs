using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();   // ViewResult, PartialViewResult, JsonResult etc 
        }


        public IActionResult About()
        {
            return View();   // ViewResult, PartialViewResult, JsonResult etc 
        }



        public IActionResult Contact()
        {
            return View();   // ViewResult, PartialViewResult, JsonResult etc 
        }   




        public String Display()
        {
            return "Hello Its Areeba";
        }

        public int DisplayId(int id)
        {
            return id;
        }



        public ContentResult ContentResult()
        {
            return Content("I am ContentResult");
        }

        public JsonResult JsonResult()
        {
            var name = "Areeba Amjad";
            return Json(new { data = name });
        }


        public PartialViewResult PartialViewResult()
        {
            return PartialView("_PartialView");
        }


        public ViewResult ViewResult()
        {
            return View("About", "Home");
        }

        public EmptyResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
