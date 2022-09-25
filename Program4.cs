using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 tip dönüşüm var
            // Implicit Conversion (Bilinçsiz Dönüşüm) yani düşük kapasiteli değerin yükseğe atanması convert.to falan yazmamıza gerek yok.
            Console.WriteLine("*****IMPLICIT CONVERSION*****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a+b+c; // int geride kalan bütün veritiplerini kapsar.
            Console.WriteLine("d:" + d); // 45 olarak döndürdü.
            long h = d;
            Console.WriteLine("h:" + h);
            float i = h;
            Console.WriteLine("i:" + i);
            // hepsinin değeri 45 bir soruc çıkmadı.
            string e = "Çağrı";
            char f = 'c';
            object g = e + f + d;
            Console.WriteLine("g:" + g); // hepsini birleşitrdi. hepsinden üstündü object.
            // explicit Conversion (Bilinçli Dönüşüm) 
            // bu ise bilinçli olarak yapmamız gereken kendi kendine olmayan dönüşünlerdir.
            Console.WriteLine("*****EXPLICIT CONVERSION*****");
            int x = 4;
            // byte y = x; yapmak istiyorum ama bunu yapamayacağım çünkü genelden özele dönüşüm oto olmuyor. elimizle yapmalıyız.
            byte y = Convert.ToByte(x); // oldu sayısaldan yazısala veya genelden özele bunula yapılır.
            Console.WriteLine("y:"+y);
            // veya şöyle de yapabiliriz:
            // int k = 8;
            // byte z = (byte)k; // bu da yukarıdaki ile aynı işi vapar.
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);
            float  w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+v); // dönüştürdü .'dan sonraki her şeyi silmiş.
            // yani veri kaybı olabilir.
            int xx = 6; // ilk tanımlamada başta yazdığımız çok önemli.
            string yy = Convert.ToString(xx);
            Console.WriteLine("yy:" + yy);
            string zz = 12.5f.ToString(); // 12.5 döndürdü. Float olarak.
            Console.WriteLine("zz:" + zz);

            // System.Convert
            Console.WriteLine("***** System.Convert sınıfı *****");
            string s1 = "10", s2 = "20"; // birden çok değişken tanımladık.
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            // PARSE: 
            Console.WriteLine("***** PARSE METHOD *****");
            ParseMethod(); // burada değişken isim sayısını tükettiğimizden başka bir fonnksiyon bloğu açıp oradan devam ediyoruz.
        }

        public static void ParseMethod() // static metotların içinden ancak staticler açılabilir. Void çünkü bir şey döndürmeyeceğim.
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1); // sadece string alır parse.
            double1 = Double.Parse(metin2);

            Console.WriteLine("metin1: " + metin1);
            Console.WriteLine("double1: " + double1); // dönüştürdü ikisini de.
        }
    }
}