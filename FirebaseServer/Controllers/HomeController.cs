using FirebaseServer.Models;
using FirebaseServer.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirebaseServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirebaseService _firebaseService;
        public HomeController(ILogger<HomeController> logger, FirebaseService firebaseService)
        {
            _logger = logger;
            _firebaseService = firebaseService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            _firebaseService.CreateServiceFaireBase();
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