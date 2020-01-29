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

    }
}
