using AlienZoo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZooDomain.Aliens
{
    public class Wookiee : Alien, IisAlien
    {
        public Wookiee()
        {
            Origin = "Star Wars";
            Color = "Brown";
           
        }
    }
}
