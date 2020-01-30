using AlienZoo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZooDomain.Aliens
{
    public class Xenomorph : Alien, IisAlien
    {
        public Xenomorph()
        {
            Origin = "Alien the movie";
            Color = "Grey";
           
        }
    }
}
