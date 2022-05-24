using Microsoft.AspNetCore.Mvc;

namespace ikinciElAracSatisSitesi.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetRegister()
        {
            return View();
        }
    }
}
