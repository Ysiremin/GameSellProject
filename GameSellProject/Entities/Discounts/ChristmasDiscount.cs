using GameSellProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities.Discounts
{
    class ChristmasDiscount : IDiscountService
    {
        public string Name()
        {
            return "Christmas Discount";
        }
        public void Discount()
        {
            Console.WriteLine("Sadece 15 Aralık - 15 Ocak arasında geçerli olan, Yılbaşı İndirimi'nden yararlandınız!");
        }
    }
}
