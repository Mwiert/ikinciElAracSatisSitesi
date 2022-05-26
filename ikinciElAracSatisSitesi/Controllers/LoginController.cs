using Microsoft.AspNetCore.Mvc;
using EntitiyLayer.Concretes;
using ServiceLayer.Concretes.dotnet;

namespace ikinciElAracSatisSitesi.Controllers
{
    public class LoginController : Controller
    {
        UserService userService= new UserService();
        Arac arac = new Arac();
        List<Arac> aracList = new List<Arac>();
        OtherService OtherService = new OtherService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string username, string password)
        {
            if (!string.IsNullOrEmpty(username))
            {
                userService.UserLogin(username, password);
                aracList = OtherService.listArac();
                ViewBag.AracList = aracList;
                return View("~/Views/User/Index.cshtml");
                
            }
            else
            {

                return View("~/Views/Login/Index.cshtml");
            }
            
        }
    }
}
