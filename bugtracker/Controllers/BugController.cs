using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Controllers
{
    public class BugController : Controller
    {
        
        public IActionResult Bugs()
        {
            return View();
        }

        public IActionResult Report()
        {
            return View();
        }
    }
}
