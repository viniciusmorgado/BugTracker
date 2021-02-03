using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models
{
    public class Bug
    {
        public int Id { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Display(Name = "Produto")]
        public string Product { get; set; }
        [Display(Name = "Versão")]
        public string Version { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Display(Name = "Tipo")]
        public string Type { get; set; } // Security, Usability etc.
    }
}
