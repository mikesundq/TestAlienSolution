using AlienZooDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZoo.Application.Interfaces
{
    public interface IPersonServices
    {
        public void AddPerson();
        public void EditPerson(int id);
        public void RemovePerson(int id);
        public Person CreatePerson(string name);

    }
}
