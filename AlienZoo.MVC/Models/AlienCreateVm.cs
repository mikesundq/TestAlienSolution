using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlienZoo.MVC.Models
{
    public class AlienCreateVm
    {
        [Display]
        public int Age { get; set; }
        [MaxLength(40)]
        [Display(Name = "Alien Name")]
        public string Name { get; set; }
        public string Color { get; set; }
        public string Origin { get; set; }
        [Required]
        public string AlienType { get; set; }
        [Required]
        public SelectList Handlers { get; set; }
        public int HandlerID { get; set; }
    }
}
