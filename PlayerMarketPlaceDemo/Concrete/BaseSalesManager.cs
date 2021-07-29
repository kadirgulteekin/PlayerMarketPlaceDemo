using PlayerMarketPlace.Abstract;
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Concrete
{
    public class BaseSalesManager : ISalesManager
    {


        public void Sale(Player player, Games games, Campaign campaign)
        {
            double GamePrice = games.GamesPrice - (games.GamesPrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(games.GamesName + " adlı oyun " + player.FirstName + " " + player.LastName + " 'e satıldı.");
            Console.WriteLine("Kampanyalı oyun tutarı : " + GamePrice + "TL");
        }
    }
}