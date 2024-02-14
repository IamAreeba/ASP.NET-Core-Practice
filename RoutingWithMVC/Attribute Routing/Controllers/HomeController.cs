using Microsoft.AspNetCore.Mvc;

namespace Attribute_Routing.Controllers
{
    //[Route("Home")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        [Route("")]
        [Route("~/")]
        //[Route("[action]")]
        //[Route("Home")]
        //[Route("Home/Index")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }


        //[Route("Home/Index")]
        //[Route("Index")]
        //[Route("[action]")]
        public IActionResult Data()
        {
            return View("~/Views/Home/Index.cshtml");
        }


        //[Route("Home/About")]
        [Route("About")]
        //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }



        //[Route("Home/Details/{id?}")]
        //[Route("Home/Details/{id?}")]    optional id using ? 
        [Route("{id?}")]

        // 1
        //public int Details(int id)
        //{
        //    return id;
        //}


        // 2
        //[Route("[action]")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
