
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Entity
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignFeature { get; set; }
        public double CampaignDiscount { get; set; }

    }
}