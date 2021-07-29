using PlayerMarketPlace.Concrete;
using PlayerMarketPlace.Abstract;
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Concrete
{
    class PlayerManager : BasePlayerManager
    {
        IPlayerCheckServise _playerCheckServise;
        public PlayerManager(IPlayerCheckServise playerCheckServise)
        {
            _playerCheckServise = playerCheckServise;
        }



        public override void Add(Player player)
        {
            if (_playerCheckServise.CheckIfRealPlayer(player))
            {
                base.Add(player);
            }
            else
            {
                Console.WriteLine("Böyle bir oyuncu yok!");
            }

        }
        public override void Delete(Player player)
        {

            if (_playerCheckServise.CheckIfRealPlayer(player))
            {
                base.Delete(player);
            }
            else
            {
                Console.WriteLine("Böyle bir oyuncu yok!");
            }
        }
        public override void Update(Player player)
        {

            if (_playerCheckServise.CheckIfRealPlayer(player))
            {
                base.Update(player);
            }
            else
            {
                Console.WriteLine("Böyle bir oyuncu yok!");
            }
        }
        public override void Sale(Player player, Games games, Campaign campaign)
        {
            if (_playerCheckServise.CheckIfRealPlayer(player))
            {
                base.Sale(player, games, campaign);
            }
            else
            {
                Console.WriteLine("Böyle bir oyuncu sistemlerimizde kayıtlı olmadğı için oyun satışı gerçekleştirilemedi!");
            }
        }


    }
}