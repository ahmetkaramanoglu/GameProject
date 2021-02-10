using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyuncuManager:IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Ad+" is saved.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Ad + " is deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Ad + " is uptaded.");
        }
       
    }
}
