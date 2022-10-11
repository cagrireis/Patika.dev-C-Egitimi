using System;

namespace MyApp
{
    internal class Problem
    {
        static void Main(string[] args)
        {
            // metodlar ile çalışmak son derece verimlidir.
            // bir classın içerisinde yazılmalı aynı class içerisindeyse direkt ismi ile erişebiliriz. fakat başka class içinde ise o classın örneği üzerinden erişebilirz.
            // geri donus yapmayacaksak void yazmalıyız asla boş kalmamlı o kısım


            // erisim_belirteci, geri donustipi, metod_adi(parametre_listesi/argüman) şeklimde yazılır.
            //{
            //
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b); // bunu metod içinde yaparsak:
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);


            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            int sonuc2 = ornek.ArttırVeTopla(ref a,ref b); // ref verdik fakat ref nedir? a ile b nin değerlerini değil de karşılığını veriyorum ve daha az yer tutar. ayrıca direkt diğer değerleri de değişyirir yani değerler fonksiyon içinde kalmaz.
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2; // erişiemedik çünkü static class içinden sadece static metodlara erişim var. 
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri) // başına public yazmazsak ulaşımı mümkün değil çünkü ulaşım izni yok.
        {
            Console.WriteLine(veri); // farklı classda yazdık main'den ulaşmak istiyorsak o classın instancesini yazmamız gerek.
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2) // ref yapınca dışarıdan içeri fonksiyona giren değerler de değişir.
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}