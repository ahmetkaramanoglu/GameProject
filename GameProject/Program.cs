using GameProject.Concreate;
using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                NationalityId="123456",
                FirstName="Ahmet",
                LastName="Karaman",
                DateOfBirth="12.04.2000",
                NickName="Marechal",
                KPoints=350,
                Level=83

            };
            Game game = new Game()
            {
                Name = "Lol",
                Price = 321
            };
            Campaign campaign = new Campaign()
            {
                Discount = 5
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            GamerManager oyuncuManager = new GamerManager(new UserValidationManager());
            oyuncuManager.Add(gamer);
            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game, gamer);

           

            salesManager.CampaignSales(game, campaign);

            
          
        }
    }
}
