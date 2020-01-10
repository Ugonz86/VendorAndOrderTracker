using Microsoft.AspNetCore.Mvc;

namespace Tracker.Controllers
{
    public class HomeController : Controllers
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}