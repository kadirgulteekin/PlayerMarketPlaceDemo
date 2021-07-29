using PlayerMarketPlace.Adapter;
using PlayerMarketPlace.Concrete;
using PlayerMarketPlace.Entity;
using System;

namespace PlayerMarketPlace
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Oyunlar
            Games games = new Games
            {
                GamesName = "Counter Strike 1.6",
                GamesCategory = " Silahlı Oyun",
                GamesPrice = 20
            };
            Games games1 = new Games
            {
                GamesName = "Wolfenstein",
                GamesCategory = " Dünya Savaşı",
                GamesPrice = 100
            };

            //Kampanyalar
            Campaign campaign = new Campaign
            {
                CampaignName = "Öğrenciye",
                CampaignDiscount = 20
            };

            Campaign campaign1 = new Campaign
            {
                CampaignName = "Yeni Mezuna",
                CampaignDiscount = 15
            };

            //Player
            Player player = new Player
            {
                FirstName = "Kadir",
                LastName = "Gültekin",
                NationalityId = "12345678910",
                DateOfBirth = new DateTime(1998, 10, 20)
            };
            Player player1 = new Player
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                NationalityId = "1234567999",
                DateOfBirth = new DateTime(1986, 1, 6)
            };

            //ManagePlayer 
            BasePlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player);
            playerManager.Add(player1);
            playerManager.Update(player);






            //ManagerGames
            BaseGameManager baseGameManager = new BaseGameManager();
            baseGameManager.Add(games);


            Console.WriteLine("******************************");

            baseGameManager.Add(games1);

            Console.WriteLine("********************************");

            //Kampanyalar

            BaseCampaignManager baseCampaignManager = new BaseCampaignManager();
            baseCampaignManager.Add(campaign);
            baseCampaignManager.Add(campaign1);

            Console.WriteLine("********************************");


            BasePlayerManager playerManager1 = new PlayerManager(new MernisServiceAdapter());
            playerManager1.Sale(player, games1, campaign);
            Console.WriteLine("***************************");
            playerManager1.Sale(player1, games1, campaign1);




            Console.ReadLine();




        }
    }
}