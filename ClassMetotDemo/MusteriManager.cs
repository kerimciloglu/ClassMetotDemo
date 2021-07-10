using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler! " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "isimli müşteri kaydı eklendi.");
        }
        public void sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "isimli müşteri kaydı başarıyla silindi.");
        }
    }
}
