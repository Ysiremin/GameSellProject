using GameSellProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities.Games
{
    class GTA5Manager : IGameService
    {
        public void Sell()
        {
            Console.WriteLine(">GTA 5 Satın Alındı.");
        }
    }
}
