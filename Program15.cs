using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // rescursive fonksiyonlar - öz yinelemeli yani kendi kednine çağırır.
            // yani fonksiyon içinde kendisini çağırabliyoruz.
            // for döngüleri ile de yapılabilir.
            // 3 ** 4 örneği:

            int temp = 1;
            for (int i = 1; i <= 4; i++)
            {
                temp *= 3;
            }
            Console.WriteLine(temp);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3 , 4));

            // bunu recursiveler ilede yapmaya çalışalım.
            // elimiz alışsın diye farklı class içinde yazmaya çalışalım.

            // extansion metotlar:
            // çok kullanırız.
            string ifade = "Çağrı REİS"; // ben verilen stringde boşluk olup olmadığını bildirecek cümle yazdırmak istiyorum.
            bool sonuc = ifade.CheckSpaces(); // extansion method direkt argümanın sağına. diyerek yazdıüımız fonksiyon.
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces()); // oldu.
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            // başka veri tiplerinde nasıl yaparız?

            int[] dizi = {9, 3, 6, 2, 1, 5, 0};
            dizi.SortArray();
            dizi.EkranaYazdir(); // sıraladı ve ekrana yazdı.

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }
            else
            {
                return Expo(sayi, üs - 1) * sayi;
            }
        }
        // expo(3,4) --> expo(3,3) * 3 --> expo(3,2)*3*3 --> expo(3,1)*3*3*3 --> 3*3*3*3 bu şekilde çalışır ve 3 üzeri 4 çalıştı.
    }

    public static class Extansion // extansion adında bir class oluşturuyorum ve extansion classlarının HEPSİ STATİC OLMALI!!!.
    {
        public static bool CheckSpaces(this string param) // eğer this yazarsak parantezin başına artık extansion metot olmuş olur.
        {
            return param.Contains(" "); // contains string kütüohanesi fonksiyonu içinde var mı diye sorguluyor.
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" "); // bu da string kütüphane fonksiyonu dedik ki param'ı boşluklara göre ayır ve diziye ekle.
            return string.Join("", dizi); // bu da kütüphane fonksiyonu listedeki elemeanları aralarına "" koyarak birleştirip string haline getirir.       
        }

        public static string MakeUpperCase(this string param) // string içindeki garflerin büyük olmasını sağlayacak fonksiyon yazıyoruz.
        {
            return param.ToUpper(); // bu da ksıa fonksiyonu. Kütüphaneden.
        }
        public static string MakeLowerCase(this string param) // bu da bütün elemanları ufaltan fonksşyon.
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param) // dizinin içindeki sayıları sıralayan bir extansion metot yazıyoruz:
        {
            Array.Sort(param); // daha öcne görmüştük.
            return param;
        }

        public static void EkranaYazdir(this int[] param) // o diziyi ekrana yazdıracak o fonksiyon:
        {
            foreach (var element in param)
            {
                Console.WriteLine(element);
            }
        }

        public static bool IsEvenNumber(this int param) // çift sayı mı fonksiyonu.
        {
            return param % 2 == 0;
        }


        public static string GetFirstCharacter(this string param) // yazılan stringin ilk karakterini döndüren fonksiyon. 
        {
            return param.Substring(0,1); // bu da library fonksiyonu başlangıç indexi ve kaç tane eleman getireceğini gireriz aradaki kısmı bize getirir.
        }
    }
}