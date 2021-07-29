using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using PlayerMarketPlace.Abstract;


namespace PlayerMarketPlace.Concrete
{
    public class BaseCampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "adlı kampanya sisteme eklendi! ");
            Console.WriteLine("Kampanya indirim oranı " + " " + campaign.CampaignDiscount + " %");
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "adlı kampanya sistemenden silindi! ");
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "adlı kampanya güncellendi! ");
            Console.WriteLine("Güncellenen kampanya indirim tutarı " + " " + campaign.CampaignDiscount);
        }
    }
}