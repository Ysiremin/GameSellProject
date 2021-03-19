using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class GameSellManager
    {
        public void Sell(Gamer gamer, IGameService game, IDiscountService discount)
        {
            Console.WriteLine("Merhaba " + gamer.FirstName + "! Satın alımınız başarı ile tamamlandı, İyi Eğlenceler !");
            game.Sell();
            discount.Discount();
        }
    }
}
