using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static sınıfı ve static sınıfı üyeleri

            // sadece adı ile erişilebilir sınıf adı yazmaya gerek yok.
            // statik olmayan classlar statik olmayan elemanlar o sınıf içerisinde nesneye özgüyken, bir sınıf içerisinde statik olan üyeler sınıf bazında atanıyor.
            
            Console.WriteLine("Çalışan sayısı: {0}.", Calisan.CalisanSayisi);

            Calisan Calisan1 = new Calisan("Ayşe", "Yılmaz", "İka"); // calisan.Isim diyerek atayamayız çünkü private sadece kurucu fonksiyon ile atayabliriz.

            Console.WriteLine("Çalışan sayısı: {0}.", Calisan.CalisanSayisi); // öncekine göre çalışan sayısı 1 artmış çünkü kurucu fonksiyon çağırıldı.

            // static ifadeler nesne ile çağrılmayan ifadelerdir.

            Calisan Calisan2 = new Calisan("Deniz", "Arda", "İk");
            Calisan Calisan3 = new Calisan("Çağrı", "Reis", "Software");

            Console.WriteLine("Çalışan sayısı: {0}.", Calisan.CalisanSayisi);

            // static classlar içerisinde her şey static olmalı. Static olmayan hiçbir şey kullanılamaz.

            // Islemler islemler = new Islemler(); erişim yok.

            Console.WriteLine(Islemler.Topla(4,5));
            Console.WriteLine(Islemler.Cikar(4,5));

            // static sınıflara kalıtım işlemi uygulanamaz.

            // kısaca;

            // Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
            
            //
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi {get => calisanSayisi;}

        private string Isim;

        private string Soyisim;

        private string Departman;

        public Calisan(string isim, string soyisim, string departman) // bu statik olmayan bir genel kurucu.
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi +=1;
        }

        static Calisan() // staticlerin erişim belirteçleri yoktur public falan olmazlar.
        {
            calisanSayisi = 0; // !! dikkat burası yani static olan kurucu fonksiyonuna sadece bir kere erişilir o da ilk kez sınıfa erişildiğinde ilk buraya gelinir.
            // yani ilk oluşturulan calisansayisidir.
        }
    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}