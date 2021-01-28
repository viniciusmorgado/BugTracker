using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Product { get; set; }
        public string Version { get; set; }
        public string Status { get; set; }
        public string Type { get; set; } // Security, Usability etc.
    }
}
