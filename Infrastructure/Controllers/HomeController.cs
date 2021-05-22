using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DonattoTech.BugTracker.Core.Models;
using DonattoTech.BugTracker.Infrastructure.Controllers;

namespace DonattoTech.BugTracker.Interface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BugsController bugsController = new BugsController();

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
    }
}
