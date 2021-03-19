using GameSellProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities.Games
{
    class TheWitcher3Manager : IGameService
    {
        public void Sell()
        {
            Console.WriteLine(">The Witcher 3 Satın Alındı.");
        }
    }
}
