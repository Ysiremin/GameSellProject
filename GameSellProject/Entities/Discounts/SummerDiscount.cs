using GameSellProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities.Discounts
{
    class SummerDiscount : IDiscountService
    {
        public string Name()
        {
            return "Summer Discount";
        }
        public void Discount()
        {
            Console.WriteLine(">Sadece yaz aylarında geçerli Yaz indirimi'nden yaralandınız!");
        }
    }
}
