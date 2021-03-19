using GameSellProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class DiscountManager
    {
        public void Add(IDiscountService discount)
        {
            Console.WriteLine(discount.Name() + " adlı yeni bir kampanya eklendi.");
        }

        public void Uptade(IDiscountService discount)
        {
            Console.WriteLine(discount.Name() + " adlı kampanya güncellendi.");
        }

        public void Delete(IDiscountService discount)
        {
            Console.WriteLine(discount.Name() + " adlı kampanya silindi.");
        }
    }
}
