using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class GamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu Kimliği Doğrulandı!");
                Console.WriteLine("Merhaba " + gamer.FirstName + ", hoşgeldin! Bizde seni bekliyorduk. \nOyuncu Kaydınız Oluşturuldu!");
            }
            else
            {
                Console.WriteLine("Oyuncu Kimliği Doğrulanamadı, Bilgilerin doğruluğunu kontrol edin ve tekrar deneyin.");
            }
        }

        public void Uptade(Gamer gamer)
        {
            Console.WriteLine("Merhaba " + gamer.FirstName + ", kaydın başarıyla güncellendi!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Aramızdan ayrıldığın için üzgünüz, " + gamer.FirstName + "." + "\nOyuncu kaydınız silindi :(");
        }
    }
}
