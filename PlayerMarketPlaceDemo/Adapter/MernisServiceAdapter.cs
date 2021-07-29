using PlayerMarketPlace.Abstract;
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

using MernisServiceReference;

namespace PlayerMarketPlace.Adapter
{
    public class MernisServiceAdapter : IPlayerCheckServise
    {
        public bool CheckIfRealPlayer(Player player)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody
                    (Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(),
                    player.LastName.ToUpper(), player.DateOfBirth.Year)))
                    .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}