using AlienZoo.Application.Interfaces;
using AlienZoo.Infrastructure.Persistance;
using AlienZooDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZoo.Infrastructure.Services
{
    public class AlienServices : IAlienServices
    {

        private readonly ApplicationDbContext context;

        public AlienServices()
        {
            
        }
        public AlienServices(ApplicationDbContext context)
        {
            this.context = context;
        }


        public void AddAlien()
        {
            throw new NotImplementedException();
        }

        public Alien CreateAlien(Alien alien, string name, int age, Person person)
        {
            alien.Name = name;
            alien.Age = age;
            alien.Handler = person;

            return alien;
        }

        public Alien CreateAlien(Alien alien, string name, int age, int HandlerID)
        {
            alien.Name = name;
            alien.Age = age;
            alien.HandlerID = HandlerID;

            return alien;
        }

        public void EditAlien(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAlien(int id)
        {
            throw new NotImplementedException();
        }
    }
}
