using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlienZoo.MVC.Models
{
    public class AlienCreateVm
    {
        [Display]
        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Origin { get; set; }
        public SelectList Handlers { get; set; }
        public int HandlerID { get; set; }
    }
}
