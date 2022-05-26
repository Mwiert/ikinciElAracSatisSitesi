using Microsoft.AspNetCore.Mvc;
using EntitiyLayer.Concretes;
using ServiceLayer.Concretes.dotnet;

namespace ikinciElAracSatisSitesi.Controllers
{
    public class HomeController : Controller
    {
        Arac arac = new Arac();
        List<Arac> aracList = new List<Arac>();
        OtherService OtherService = new OtherService();
        public IActionResult Index()
        {
            aracList = OtherService.listArac();
            ViewBag.AracList = aracList;
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
