using GameSellProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities.Discounts
{
    class WelcomeDiscount : IDiscountService
    {
        public string Name()
        {
            return "Welcome Discount";
        }
        public void Discount()
        {
            Console.WriteLine(">Yeni katılan oyuncularımızın yararlanabildiği Hoşgeldin İndirimi'nden yararlandınız!");
        }
    }
}
