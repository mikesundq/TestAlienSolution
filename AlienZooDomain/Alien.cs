using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZooDomain
{
    public class Alien
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Origin { get; set; }
        public Person Handler { get; set; }
    }
}
