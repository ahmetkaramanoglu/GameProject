using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " is added.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + "doesn't added.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " is deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " is uptaded.");
        }
       
    }
}
