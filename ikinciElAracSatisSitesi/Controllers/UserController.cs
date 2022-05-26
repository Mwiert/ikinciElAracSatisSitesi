using Microsoft.AspNetCore.Mvc;
using EntitiyLayer.Concretes;
using ServiceLayer.Concretes.dotnet;

namespace ikinciElAracSatisSitesi.Controllers
{
    public class UserController : Controller
    {
        Arac Arac = new Arac();
        List<Arac> AracList = new List<Arac>();
        OtherService OtherService = new OtherService();
        public IActionResult Index()
        {
            AracList = OtherService.listArac();
            ViewBag.AracList = AracList;
            return View();
        }
        public IActionResult routetoAdd()
        {
            return View("~/Views/User/AracEkle.cshtml");
        }
        public IActionResult ilanKoy(Arac arac)
        {
            if (!string.IsNullOrEmpty(arac.Marka))
            {
                Arac.Marka = arac.Marka;
                Arac.AracTuru = arac.AracTuru;
                Arac.YakıtTuru = arac.YakıtTuru;
                Arac.OnayDurumu = false;
                Arac.ParkSensoru = arac.ParkSensoru;
                Arac.Model = arac.Model; ;
                Arac.SatisFiyati = arac.SatisFiyati;
                Arac.MKS = arac.MKS; ;
                Arac.CamTavan = arac.CamTavan;
                Arac.SisFari = arac.SisFari;
                Arac.UretimYili = arac.UretimYili;
                Arac.Km = arac.Km; ;
                Arac.MotorHacmi = arac.MotorHacmi;
                Arac.KatlanılabilirAyna = arac.KatlanılabilirAyna;
                Arac.AracResim = arac.AracResim;

                OtherService.AracEkle(arac);
                return View("~/Views/User/Index.cshtml");
            }
            else
            {
                return View("~/Views/User/AracEkle.cshtml");
            }
        }
    }
}
