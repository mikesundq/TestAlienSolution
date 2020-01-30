using AlienZoo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace AlienZooDomain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Alien> HandledAliens { get; set; } = new List<Alien>();
    }
}
