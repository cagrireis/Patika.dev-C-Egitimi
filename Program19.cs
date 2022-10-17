using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<t> class
            // System.Collections.Generic
            // T --> object türündedir. 

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi= new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count

            Console.WriteLine(renkListesi.Count());
            Console.WriteLine(sayiListesi.Count());

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            // listelerin üzerinde foreach ile gezinmek için bir yol daha var.

            Console.WriteLine("*** Farklı Foreach ***");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarmak için de iki farklı metod vardır.

            Console.WriteLine("*** Remove Sonrası ***");

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Index İle Çıkarma:

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);

            Console.WriteLine("*** RemoveAt Sonrası ***");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste İçerisinde Arama:

            if (sayiListesi.Contains(10)) // böyle aranabilir.
            {
                Console.WriteLine($"10 sayiListesi içerinide bulundu.");
            }

            // eleman ile indexe erişmek : 

            Console.WriteLine(renkListesi.BinarySearch("Sarı")); // bulunduğu indexi getirir.

            // Diziyi Listeye Çevirme:

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar); // bu şekilde dönüştürürülür.

            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            // listeyi nasıl temizleriz?

            hayvanListesi.Clear();

            Console.WriteLine("**** Clear'dan sonra ****");

            hayvanListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            // listeye nesne atamak istyorsam yani veri tipi değil de genel nesne

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();

            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yılaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();

            kullanici2.Isim = "Özcan";

            kullanici2.Soyisim = "Çalışkan";

            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2); // kullanıcılar classının nesnelerinden oluşan kullanıcılar tipinde bir listeye 2 tane kullanıcı ekledim ve kullanıcıların kendi içinde 3 tane öxelliği var.

            List<Kullanicilar> yeniListe = new List<Kullanicilar>(); // burada yine kullanicilar tipinde liste oluşturdum.
            yeniListe.Add(new Kullanicilar() // burada ise daha hızlı bir yoldan değer atama yaptım.
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas=24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanici.Isim);
                Console.WriteLine("Kullanıcı Adı:" + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Adı:" + kullanici.Yas);
            }

            yeniListe.Clear(); // bu şekilde de temizlenebilir.
        }
    }
    public class Kullanicilar // listeye nesne atamak için aşağıdaki gibi yapmalıyız bu konuya daha sonra döneceğiz.
    {
        private string isim; // burada değerler saklanır ve korunur.

        private string soyisim; // kapsül

        private int yas;

        public string Isim{get => isim; set => isim = value; } // burada ise döndürülür.
        public string Soyisim{get => soyisim; set => soyisim = value; } // enkapsül
        public int Yas{get => yas; set => yas = value; }
    }
}