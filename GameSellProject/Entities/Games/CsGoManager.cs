using GameSellProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities.Games
{
    class CsGoManager : IGameService
    {
        public void Sell()
        {
            Console.WriteLine(">Cs GO Satın Alındı.");
        }
    }
}
