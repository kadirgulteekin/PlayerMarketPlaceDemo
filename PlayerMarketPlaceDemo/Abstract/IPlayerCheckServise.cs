using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Abstract
{
    interface IPlayerCheckServise
    {
        bool CheckIfRealPlayer(Player player);
    }
}