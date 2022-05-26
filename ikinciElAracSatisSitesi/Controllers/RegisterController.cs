using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Concretes.dotnet;
using EntitiyLayer.Concretes;

namespace ikinciElAracSatisSitesi.Controllers
{
    public class RegisterController : Controller
    {
        UserService userService = new UserService();

        public IActionResult Index()
        {
            return View("~/Views/Register/Index.cshtml");
        }

        public IActionResult GetRegister(string ad,string soyad,string username,string password,string passwordCheck)
        {
            User User = new User();
            if (password == passwordCheck)
            {
                User.Ad = ad;
                User.Soyad = soyad;
                User.Email = username;
                User.Password = password;
                userService.userRegister(User);
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return RedirectToAction("Index", "Register");
            }
        }
    }
}
