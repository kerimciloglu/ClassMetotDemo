using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Kerim";
            musteri1.MusteriSoyadi = "Çiloğlu";
            musteri1.MusteriYas = 19;
            musteri1.MusteriNo = 123456789;
            musteri1.MusteriBilgisi = "Sicili temiz. Kredi talebi onaylanmıştır.";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Kadir";
            musteri2.MusteriSoyadi = "Çiloğlu";
            musteri2.MusteriYas = 22;
            musteri2.MusteriNo = 234567891;
            musteri2.MusteriBilgisi = "Sicili temiz. Kredi talebi onaylanmıştır.";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Gülcan";
            musteri3.MusteriSoyadi = "Çiloğlu";
            musteri3.MusteriYas = 42;
            musteri3.MusteriNo = 345678912;
            musteri3.MusteriBilgisi = "Sicili temiz. Kredi talebi onaylanmıştır.";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAdi = "Cahit";
            musteri4.MusteriSoyadi = "Çiloğlu";
            musteri4.MusteriYas = 43;
            musteri4.MusteriNo = 456789123;
            musteri4.MusteriBilgisi = "Sicili temiz. Kredi talebi onaylanmıştır.";

            Musteri[] x = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in x)
            {
                Console.WriteLine("Müşteri Adı           : " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı        : " + musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri Yaşı          : " + musteri.MusteriYas);
                Console.WriteLine("Müşteri Numarası      : " + musteri.MusteriNo);
                Console.WriteLine("Müşteri Kredi Bilgisi : " + musteri.MusteriBilgisi);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("----------------------------------------------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("********************************************************************************");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("********************************************************************************");
            musteriManager.Ekle(musteri3);
            Console.WriteLine("********************************************************************************");
            musteriManager.Ekle(musteri4);
            Console.WriteLine("********************************************************************************");

            musteriManager.sil(musteri1);
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("---------------------------Müşteri Listesi--------------------------------------");
            Musteri[] musteriler ={ musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
            }
        }
    }
}
