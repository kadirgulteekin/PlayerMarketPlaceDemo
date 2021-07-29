using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Abstract
{
    interface ISalesManager
    {
        void Sale(Player player, Games games, Campaign campaign);
    }
}