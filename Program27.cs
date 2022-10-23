using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enum, enumeration kısaltmasıdır.
            // sıralama anlamına gelir, sıralı olan veriler ile çalışma noktasında yani indexli veriler ile çalışma noktasında çok kullanışlı oluyor.

            // birden çok değeri bilinen sabitlerde kodun okunurluğunu arttırmak için enumları kullanırız.

            Console.WriteLine(Günler.Pazar);
            Console.WriteLine(Convert.ToInt32(Günler.Cumartesi)); // bu şekilde numerik değerine ulaşabiliriz.

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            }
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım.");
            }
        }
    }

    enum Günler // class gibi tanımlanır.
    {
        Pazartesi, // ismi string vermiş olmamaız string tuttuğu anlamına gelmez. "" içerisinde yazmıyoruz. Biz burada elemanın ismini belirliyoruz ve sıra ile indexliyor pazartesi 0 mesela.
        Salı, // = diyerek indexleri kendimiz atabiliriz.
        Çarşamba, // burada yaptığımız şey böyle ifadeler ile sayılar tutmaktır. Çarşamba 2. indextir mesela.
        Perşembe,
        Cuma = 23, // böyle yaparsak 0 1 2 3 diye gelirken 23 olur ve cumartesi 24 pazar 25 olur. Sıra ile takip eder.
        Cumartesi,
        Pazar
    }

    enum HavaDurumu // burada değişmeyecek ve programda kullancağım bazı verileri tutmak istiyorsam da kullanabiliriz.
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }
}