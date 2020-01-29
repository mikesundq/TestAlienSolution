using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AlienZoo.Infrastructure.Services;
using AlienZooDomain;
using AlienZooDomain.Aliens;

namespace TestAlienZoo
{
    public class TestAlienServices
    {
        [Fact]
        public void CreateAlien_NormalAlien_Success()
        {
            var alienSerivces = new AlienServices();

            var newPerson = new Person
            {
                Name = "Börje"
            };

            var newPredator = new Predator();
            var newAlien = alienSerivces.CreateAlien(newPredator, "Börje", 150, newPerson);

            Assert.Equal("Börje", newAlien.Name);
        }


        public void AddAlien_NormalPush_Correct()
        {
            throw new NotImplementedException();
        }

        public void EditAlien_(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAlien_(int id)
        {
            throw new NotImplementedException();
        }
    }
}
