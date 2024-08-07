using Microsoft.AspNetCore.Mvc;

namespace routesASPApplication.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/date")]
        public int date(int id)
        {
            return id;
        }
    }
}
