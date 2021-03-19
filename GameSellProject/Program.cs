using GameSellProject.Abstract;
using GameSellProject.Adapters;
using GameSellProject.Concrete;
using GameSellProject.Entities;
using GameSellProject.Entities.Discounts;
using GameSellProject.Entities.Games;
using System;

namespace GameSellProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
             
            IGameService csGoManager = new CsGoManager();
            IGameService gTA5Manager = new GTA5Manager();
            IGameService theWitcher3Manager = new TheWitcher3Manager();

            IDiscountService welcomeDiscount = new WelcomeDiscount();
            IDiscountService christmasDiscount = new ChristmasDiscount();
            IDiscountService summerDiscount = new SummerDiscount();

            GameSellManager gameSellManager = new GameSellManager();

            DiscountManager discountManager = new DiscountManager();

            //Gamer1 = Yasir Emin ÇİFTÇİ

            gamer1.IdentityNumber = "14347132386";
            gamer1.FirstName ="Yasir Emin";
            gamer1.LastName ="Çiftçi";
            gamer1.DateOfBirth = new DateTime(1997, 3, 5);
            gamer1.Id = 1;
            // Ağustos indirimleri Adlı bir kampya girişi yapılıyor.

            discountManager.Add(summerDiscount);
            Console.WriteLine("---------------------");

            // Yeni oyuncu kaydı yapılıyor

            gamerManager.Add(gamer1);
            Console.WriteLine("---------------------");

            // Yasir adlı oyunucu, The Witcher 3 oyununu hoş geldiniz indirimi ile satın alıyor.

            gameSellManager.Sell(gamer1, theWitcher3Manager, welcomeDiscount);
        }
    }
}
