using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " kullanici " + game.Name + " adli oyunu aldi.");
        }
        public void CampaignSales(Game game,Campaign campaign)
        {
            Console.WriteLine(game.Name + " oyunu %" + campaign.Discount + " indirime girdi.");
        }
    }
}
