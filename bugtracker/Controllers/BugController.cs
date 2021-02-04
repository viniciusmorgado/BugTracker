using bugtracker.Data;
using bugtracker.Models;
using bugtracker.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Controllers
{
    [Route("bug/[controller]")]
    public class BugController : Controller
    {
        private readonly IBugService _bugService;
        public BugController(IBugService bugService)
        {
            _bugService = bugService;
        }

        // Get bug/{values}
        [HttpGet]
        public async Task<IEnumerable<Bug>> GetAllAsync()
        {
            var bugs = await _bugService.ListAsync();
            return bugs;
        }

        // Get bug/{values}/{id}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
