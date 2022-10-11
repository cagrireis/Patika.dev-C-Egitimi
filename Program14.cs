using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aynı isim ile birçok fonksiyonu overloading ile kullanabiliriz.
            // out paramtreler
            // bir fonksiyona bir iş yaptırıp ve ona sonucunda bir değeri setlemesini isteyip kullanmasını istiyorsak out parametresi ile kullanırız.

            string sayi = "999"; // diyelim ki bunu integera dönüüştürüp kullanmak istiyorum ancak ben bunu fönüştürmeyi güven altına almak isityorum.

            bool sonuc = int.TryParse(sayi, out int outSayi); // burada dedik ki sayıyı çevirmeye çalış oluyorsa outSayi olarak döndür.
            // argüman, out, dönüt

            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int ToplamSonucu); // return yerine bu şekilde de değer döndürülebilir void fonksiyonlardan.
            Console.WriteLine(ToplamSonucu);

            // Metot aşırı yükleme - overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade)); // int vermeye çalıştım olmadı. Convertleme ile olabiliyor. 

            // bunun başka bir yolu olmalı 
            instance.EkranaYazdir(ifade);

            instance.EkranaYazdir("Çağrı ", "REİS");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam) // toplam adlı argmanı outlayacağımızı söyledik fakat varlığı önemli simini değiştirebiliriz kullanımda.
        {
            toplam = a+b; // return demedim out kullandım ve fonksiyon void.
        }

        public void EkranaYazdir(string veri) // string veri alıyor 
        {
            Console.WriteLine(veri);
        }

        // hem int hem string girdi alabilecek fonksiyon mümkün.

        public void EkranaYazdir(int veri) // int veri alıyor 
        {
            Console.WriteLine(veri);
        } // artık bu fonksiyonun hem int hem string veri alan bir tipi var overload etmiş olduk.

        // bunu genişletebiliriz.

        public void EkranaYazdir(string veri1, string veri2) // public ve void ismini değişemeyiz ancak aldığı argümanlar ile overload yapabiliriz.
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}