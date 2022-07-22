using Microsoft.AspNetCore.Mvc;

namespace Animal_shelter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }


    }
}
