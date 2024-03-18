using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            // ======================== ViewBag.<> Concept ====================
            ViewBag.Data1 = "Areeba Amjad";
            ViewBag.Data2 = 12345;
            ViewBag.Data3 = DateTime.Now.ToShortDateString();

            ViewData["MyFamily"] = "Latif family";
            ViewBag.Data6 = "Welcome";


            string[] Array1 = { "Shazia", "Shaheryar", "Amjad", "Haseeb" };
            ViewBag.Data4 = Array1;

            ViewBag.Data5 = new List<string>()
            {
                "Harry Potter", "X-Men", "Twilight"
            };

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

/* 
    // ======================== ViewData[] Concept ====================
    // Single DT
    ViewData["Data1"] = "Areeba Amjad";
    ViewData["Data2"] = "Studying At UBIT";
    ViewData["Data3"] = DateTime.Now.ToLongDateString(); // In it month name will be displayed

    // Arrays Collection
    string[] Array = { "Areeba", "Aiman", "Ali" };
    ViewData["Data4"] = Array;

    // Generic List
    ViewData["Data5"] = new List<String>()
    {
        "Cricket", "Football"
    };  

 */