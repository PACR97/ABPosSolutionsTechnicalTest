using ABPosSolutions.TechnicalTest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ABPosSolutions.TechnicalTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Inspector"))
            {
                return RedirectToAction("Index", "Inspector");
            }else if (User.IsInRole("Supervisor"))
            {
                return RedirectToAction("Index", "Supervisor");
            }
            return View();
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