using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using AlienZoo.Infrastructure.Services;
using AlienZooDomain;
using AlienZooDomain.Aliens;

namespace TestAlienZoo
{
    public class TestAlienServices
    {
        private readonly ITestOutputHelper output;

        public TestAlienServices(ITestOutputHelper output)
        {
            this.output = output;
        }
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
            output.WriteLine($"newAlien is of type {newAlien.GetType()}");
            Assert.Equal("Börje", newAlien.Name);
        }

        [Fact]
        public void CreateAlien_CheckType_GetReturnType()
        {
            //Arrange
            var alienSerivces = new AlienServices();

            var newPerson = new Person
            {
                Name = "Börje"
            };

            var newPredator = new Predator();
            //Act
            var newAlien = alienSerivces.CreateAlien(newPredator, "Börje", 150, newPerson);
           

            //Assert
            Assert.Equal(typeof(Predator), newAlien.GetType());
            
        }

        /*
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
        }*/
    }
}
