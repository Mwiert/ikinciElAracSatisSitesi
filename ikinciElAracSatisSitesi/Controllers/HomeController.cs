using Microsoft.AspNetCore.Mvc;

namespace ikinciElAracSatisSitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
