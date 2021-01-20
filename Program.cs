using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself
            //değer tutucu - alias

                    // VERİ TİPLERİ 

            //string kategoriEtiketi = "Kategoriler";
            //char character = 'A';
            //int ogrenciSayisi = 3200000;
            //long ogrenciSayisi1 = 32000000000;
            //short ogrenciSayisi2 = 32767;
            //byte ogrenciSayisi3 = 255;
            //double ondalıklıSayi = 10.5;
            //decimal ondalıklıSayi1 = 100000.5M;
            //decimal ondalıklıSayi2 = 100000.5m;
            //enum Days
            //{
            //    Monday,Tuesday,Wednesday,Thursday,Friday
            //}

            string kategoriEtiketi = "Son";
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
