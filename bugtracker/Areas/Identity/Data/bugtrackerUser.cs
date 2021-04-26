using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace bugtracker.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the bugtrackerUser class
    public class bugtrackerUser : IdentityUser
    {
        public override string Email { get; set; }
        public string Password { get; set; }
    }
}
