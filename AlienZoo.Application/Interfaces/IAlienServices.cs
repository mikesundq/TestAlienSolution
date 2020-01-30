using AlienZooDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZoo.Application.Interfaces
{
    public interface IAlienServices
    {
        public void AddAlien();
        public void EditAlien(int id);
        public void RemoveAlien(int id);

        public Alien CreateAlien(Alien alien, string name, int age, Person person);
        public Alien CreateAlien(Alien alien, string name, int age, int HandlerID, string alienType);

    }
}
