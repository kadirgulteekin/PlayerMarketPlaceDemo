using PlayerMarketPlace.Abstract;
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Concrete
{
    public abstract class BasePlayerManager : IPlayerService, ISalesManager
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine(player.FirstName + "  " + player.LastName + "  " + "isimli oyuncu sisteme eklendi! ");
        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + "  " + player.LastName + " " + "isimli oyuncu güncellendi! ");
        }

        public virtual void Sale(Player player, Games games, Campaign campaign)
        {
            double GamePrice = games.GamesPrice - games.GamesPrice * (campaign.CampaignDiscount / 100);
            Console.WriteLine(games.GamesName + " adlı oyun " + player.FirstName + " " + player.LastName + " 'e satıldı.");
            Console.WriteLine("Kampanyalı oyun tutarı : " + GamePrice + "TL");
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " " + "isimli oyuncu sistemden atıldı!");
        }
    }
}