using Microsoft.AspNetCore.Mvc;

namespace uxcomexweb.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
