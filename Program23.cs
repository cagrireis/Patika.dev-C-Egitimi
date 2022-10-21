using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kurucu metotlar
            // bir nesneyi new ile oluşturduğumuzda arkada kendi kendine çalışan metotlara kurucu metotlar denir.
            // erişim belirteçleri public olmalı ve geriye bir şey döndürmez fakat boştur void değildir.

            // geçen ders yaptığımız kodu iyileştirip kurucu metotlar ile yazalım;

            //------------------------------------------------------------------------------------------------------------------------------
            Calisan Calisan1 = new Calisan();

            Calisan1.Ad = "Ayşe";
            Calisan1.Soyad = "Kara";
            Calisan1.No = 23415634;
            Calisan1.Departman = "Insan Kaynakları";

            Console.WriteLine("***** Calisan1");

            Calisan1.CalisanBilgileri(); 

            Console.WriteLine("*************************");

            Calisan Calisan2 = new Calisan();

            Calisan2.Ad = "Deniz";
            Calisan2.Soyad = "Arda";
            Calisan2.No = 25646789;
            Calisan2.Departman = "Satın Alma";

            Console.WriteLine("***** Calisan2");

            Calisan2.CalisanBilgileri();
            //------------------------------------------------------------------------------------------------------------------------------

            Calisan Calisan3 = new Calisan("Çağrı", "REİS", 21042099, "Yazılım"); // oluşturuldu.

            Console.WriteLine("***** Calisan3");

            Calisan3.CalisanBilgileri();

            Calisan Calisan4 = new Calisan("Elon", "Musk", 121243212, "Rocket Propel");
            Calisan Calisan5 = new Calisan("Bill", "Gates", 12345678, "Micro");

            Console.WriteLine("***** Calisan4");

            Calisan4.CalisanBilgileri();
            Console.WriteLine("***** Calisan5");
            Calisan5.CalisanBilgileri(); // 5 satırlık işlemi 1 satırda yaptık.

            Console.WriteLine("***** Calisan6");

            Calisan Calisan6 = new Calisan("Patrick", "Bateman");
            Calisan6.CalisanBilgileri();
            // diğer bilgilerini de atarsak;

            Console.WriteLine("***********************no departman olan:");

            Calisan6.No = 21120440;
            Calisan6.Departman = "Office";

            Calisan6.CalisanBilgileri();

            // görüldüğü üzere propertyler setlenmezse stringse null, intse 0 olarak atar. boolean ise false olarak atar.
            // zaten biz hiç kurucu fonksiyon oluştumasak bile içi boş olarak oluşturduğumuz kurucu fonksiyon çalışıyor gibi olacak.
            // ihtiyaca göre bu şekilde kurucu (Constructorlar) yazılabilir.
        }
    }

    class Calisan
    {
        public string Ad;

        public String Soyad;

        public int No;

        public string Departman;

        // kurucu fonksiyon;

        public Calisan(string ad, string soyad, int no, string departman) // ismi class ismi ile aynı olmalı. Yukarıdaki propertylerin ilk değerlerini atayalım.
        { // bu otomatik çalışan method yani bir new Calisan() yazdığımızda çalışacak.
        // kurucu metotlar overload edilebilir.
            Ad = ad; // veya this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        // bir tane daha kurucu metot oluşturalim ki man içindeki yazdığımız atamalar çalışmaya devam etsin. Aynı zamanda overload kısmını hatırlayalım.

        public Calisan()
        {}

        // diyelim ki çalışan yeni kaydolunca numarası ve departmanı belli olmayabilir. sadece ad ve soyad'ı özelleştiren bir kurucu metot yazalım.

        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            this.Soyad = soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}