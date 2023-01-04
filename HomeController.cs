using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TekCiftSayiWebApplication.Models;

namespace TekCiftSayiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(TekCiftSayi tekCiftSayi)
        {
            var sayi = tekCiftSayi.Sayi;
            if (sayi % 2 == 0)
            {
                ViewBag.Message = "Girilen sayı çift sayıdır";
            }

            else {
                ViewBag.Message = "Girilen sayı tek sayıdır";

            }
            return View("tekCiftSayi");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}