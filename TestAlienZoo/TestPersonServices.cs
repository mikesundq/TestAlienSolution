using AlienZoo.Infrastructure.Services;
using AlienZooDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AlienZoo.Application;

namespace TestAlienZoo
{
    public class TestPersonServices
    {
        [Fact]
        public void CreatePerson_NormalPerson_Success()
        {
            var personservices = new PersonServices();

            var newPerson = new Person()
            {
                Name = "Börje"
            };

            var expectedPerson = newPerson;

            var actualPerson = personservices.CreatePerson("Börje");

            Assert.Equal(expectedPerson.Name, actualPerson.Name);

        }
        
        /*
        public void AddPerson_NormalPush_Correct()
        {
            throw new NotImplementedException();
        }
        */
        /*
        public void EditPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePerson(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}
