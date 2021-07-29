using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);

    }
}