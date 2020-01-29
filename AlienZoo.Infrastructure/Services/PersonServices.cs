using System;
using System.Collections.Generic;
using System.Text;
using AlienZoo.Application.Interfaces;
using AlienZooDomain;

namespace AlienZoo.Infrastructure.Services
{
    public class PersonServices : IPersonServices
    {
        public void AddPerson()
        {
            throw new NotImplementedException();
        }

        public void EditPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Person CreatePerson(string name)
        {

            var newPersonToAdd = new Person()
            {
                Name = name
            };

            return newPersonToAdd;
        }
    }
}
