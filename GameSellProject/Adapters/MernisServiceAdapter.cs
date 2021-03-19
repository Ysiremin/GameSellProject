using GameSellProject.Abstract;
using GameSellProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
