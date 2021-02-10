using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " is added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " is deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " is updated");
        }
    }
}
