using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is delete.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated.");
        }
    }
}
