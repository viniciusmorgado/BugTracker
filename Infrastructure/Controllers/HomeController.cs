using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DonattoTech.BugTracker.Infrastructure.Controllers;

namespace DonattoTech.BugTracker.Interface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BugsController bugsController = new BugsController();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var bugsList = bugsController.Get();
            return View(bugsList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bug()
        {
            var bugsList = bugsController.Get();
            return View(bugsList);
        }

        public IActionResult Report()
        {
            return View();
        }
    }
}
