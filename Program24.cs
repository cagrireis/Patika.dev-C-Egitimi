using System;
using System.Collections.Generic;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation

            // nesne yönelimli programlamanın temellerinden.
            // bir nesnenin bazı özelliklerini ve işlevlerini, metotlarını diğer class ve nesnelerden korumak anlamına gelir.
            // biz bunu erişim belirleyiciler ile yaparız.
            // biz enkapsülasyon ile bunları manipule edebiliriz.
            // get ve set ile yaparız. get private değerini getiren, set kısmı ise private değere bir şey set eden olarak tanımlanabilir.

            Ogrenci Ogrenci1 = new Ogrenci("Çağrı", "Reis", 21042099, 92); // insatance yani nesne oluşturalım.

            Ogrenci1.OgrenciBilgileri();
            Console.WriteLine("****** Sınıf değiştirdikten aonra ******");
            Ogrenci1.SinifDeğistir(100);
            Ogrenci1.OgrenciBilgileri();
            Console.WriteLine("****** Sınıf azalttıktan sonra ******");
            Ogrenci1.SinifDusur();
            Ogrenci1.OgrenciBilgileri();
            Console.WriteLine("****** Sınıf arttırdıktan sonra ******");
            Ogrenci1.SinifArttir();
            Ogrenci1.OgrenciBilgileri();

            // -----------------------------------------------------------------

            Ogrenci Ogrenci2 = new Ogrenci();
            Ogrenci2.Isim = "Deniz";
            Ogrenci2.Soyisim = "Arda";
            Ogrenci2.OgrenciNo = 256;
            Ogrenci2.Sinif = 1;
            Ogrenci2.OgrenciBilgileri();

            Console.WriteLine("***** Sınıf azaltması *****");

            Ogrenci2.SinifDusur();

            Ogrenci2.OgrenciBilgileri(); // görüldüğü üzere daha da düşürmüyor sınıf en az 1 olabilir diye uyarı verdi.
        }
    }

    class Ogrenci
    {
        private string isim; // şimdi biz bu privateleri oluşturduk fakat biz bunları kullanmak istiyoruz. Bunun için bunlara karşılık gelen public propertyleri oluşturalım.
        private string soyisim; // control + . ile kısayoldan oluşturulabilir.
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; } // kısayoldan oluşturdu.

        public string Soyisim // böyle de yazılabilir.
        {
            get { return soyisim; }
            set { soyisim = value; }
        }

        public int OgrenciNo{get => ogrenciNo; set => ogrenciNo = value;}

        public int Sinif // şimdi burada sınıf eğer 0 olursa metotlar ile daha düşük olmasın diye bir işlem yapmalıyım. Bunu metot içinde de yapabilirim. Ama bu daha güvenli.
        {
            get => sinif; 

            set 
            { 
                if (sinif > 1)
                {
                    sinif = value; 
                }
                else
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
            }
        }

        public Ogrenci() // boş olan kurucu oluşturuyorum diğerlerinden sonra boş olursa sıkıntı çıkmasın diye overload ile.
        {}

        // kurucu metotları kısayol ile yine oluşturabiliriz. control + . ile add parameter ile.

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif) // bunda hepsini girerek çağırabiliriz ya da diğerinde boş da çağırabiliriz.
        {
            Isim = isim; // this ile de yapılabilir unutma.
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        // bir de öğrenci bilgisi döndüren bir normal fonksiyon yazalım.

        public void OgrenciBilgileri()
        {
            Console.WriteLine("***** ÖĞRENCİ BİLGİLERİ *****");
            Console.WriteLine($"Ogrenci ismi:     {this.Isim}");
            Console.WriteLine($"Ogrenci Soyismi:  {this.Soyisim}");
            Console.WriteLine($"Ogrenci numarası: {this.OgrenciNo}");
            Console.WriteLine($"Ogrenci sınıfı:   {this.Sinif}");
        }

        // birkaç yardımcı metot yazalım.

        public void SinifDeğistir(int _sinif)
        {
            this.Sinif = _sinif;
        }

        public void SinifArttir()
        {
            this.Sinif +=1;
        }

        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}