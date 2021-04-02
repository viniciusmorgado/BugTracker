using bugtracker.Data;
using bugtracker.Models;
using bugtracker.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IBugRepository _bugRepository;
        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
            _bugRepository = new BugRepository(new BugDbContext());
        }

        public IActionResult Index()
        {
            var bugs = from bug in _bugRepository.GetBugs()
                       select bug;
            return View(bugs);
        }
        /*public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }*/

        public async Task<IActionResult> Privacy()
        {
            return await Task.Run(() => View());
        }

        public async Task<IActionResult> Report()
        {
            return await Task.Run(() => View());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return await Task.Run(() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }));
        }
    }
}
