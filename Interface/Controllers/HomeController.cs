using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DonattoTech.BugTracker.Infrastructure.Controllers;
using System.Threading.Tasks;
using System.Collections.Generic;
using DonattoTech.BugTracker.Core.Models;

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

        public async Task<IActionResult> Index()
        {
            var bugsListLastMonth = bugsController.GetLastMonths();
            return await Task.Run(() => View(bugsListLastMonth));
        }

        public async Task<IActionResult> Privacy()
        {
            return await Task.Run(() => View());
        }

        public async Task<IActionResult> Bug()
        {           
            var bugsLists = bugsController.Get();
            return await Task.Run(() => View(bugsLists));
        }

        public async Task<IActionResult> Report()
        {
            return await Task.Run(() => View());
        }
    }
}
