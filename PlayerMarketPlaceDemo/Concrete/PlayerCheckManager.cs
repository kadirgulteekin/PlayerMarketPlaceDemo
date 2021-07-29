using PlayerMarketPlace.Abstract;
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Concrete
{
    public class PlayerCheckManager : IPlayerCheckServise
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}