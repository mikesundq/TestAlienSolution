using AlienZoo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZooDomain.Aliens
{
    public class Predator : Alien, IisAlien
    {
        public Predator()
        {
            Origin = "Predator";
            Color = "Invisible";
            
        }
    }
}
