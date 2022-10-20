using System;
using System.Collections.Generic;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi

            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi; (property)
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]) (metotlar)
            //     {
            //         Metot Komutları
            //     }
            // }

            // nesne yönelimlide çok önemli.
            // c# için nesneler bir sınıf içinde olmalı.
            // Sınıflara bölmenin nedeni her şeyi bir fonksiyon içine yazmadığımız gibi nesneleri de ayrımamız faydalı olacaktır.
            // metotları da bu şekilde bölebiliriz.
            // sınıflara ayırırsak her grubun sorumluluğu ayrı oluyor.
            // sınıflar metotlar ve propertylerden yani özelliklerden oluşur.

            // Erişim Belirleyiciler:

            // * Public (Her yerden erişilebilir. programın herhangi noktasından erişebiliriz.)
            // * Private (Sadece tanımlandığı sınıf içerisinde erişilebilir.)
            // * Internal (sadece kendi bulunduğu proje içerisinde [büyük projelerde önemli] örnek olarak cs.proj dosyası verilebilir.)
            // * Protected (sadece tanımlandığı sınıfta ve/veya o sınıftan kalıtım alan diğer sınıflarda erişilebilir.)

            // Örnek program:


            // şimdi de yarattığımız class'dan bir instance(yani örnek yaratacağız.)

            Calisan Calisan1 = new Calisan();

            Calisan1.Ad = "Ayşe";
            Calisan1.Soyad = "Kara";
            Calisan1.No = 23415634;
            Calisan1.Departman = "Insan Kaynakları";

            Calisan1.CalisanBilgileri(); // bu şekilde çağırabiliyoruz. Nesne aracılığı ile hiç argüman almayan fonksiyonumuzu yazdırdık.

            Console.WriteLine("*************************");

            Calisan Calisan2 = new Calisan();

            Calisan2.Ad = "Deniz";
            Calisan2.Soyad = "Arda";
            Calisan2.No = 25646789;
            Calisan2.Departman = "Satın Alma";

            Calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        // property tanımlayarak başlayalım.

        public string Ad;

        public String Soyad;

        public int No;

        public string Departman;

        // bir de yukarıdaki bilgileri getiren metot yazalım

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}