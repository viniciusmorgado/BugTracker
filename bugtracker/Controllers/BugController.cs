using bugtracker.Data;
using bugtracker.Models;
using bugtracker.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Controllers
{
    public class BugController : Controller
    {
        private readonly IBugRepository _bugRepository;
        
        public BugController()
        {
            this._bugRepository = new BugRepository(new BugDbContext());
        }

        public async Task<IActionResult> Bugs()
        {
            var bugs = from bug in _bugRepository.GetBugs()
                       select bug;
            return await Task.Run(() => View(bugs));
        }
    }
}