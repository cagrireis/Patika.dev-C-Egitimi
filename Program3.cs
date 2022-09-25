using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama:
            int x = 3;
            int y = 8;
            y = y + 2; // Bu normalde yaptığımız.
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2; // bunlarda = sonda kullanılır ve işlemi eşittirden sonraki sayı ile değişkene uygula demektir.
            Console.WriteLine(x);
            Console.WriteLine(y);
            // Mnatıksal Operatörler:
            // ||, &&, ! (Bunlar sırası ile veya, ve, değil.)
            bool isSuccess = true;
            bool isCompleted =false;
            if(isSuccess && isCompleted) // her ikisi de true olmalı.
            {
                Console.WriteLine("Perfect");
            }
            if(isSuccess || isCompleted) // her ikisinden biri true ise
            {
                Console.WriteLine("Great");
            }
            if(isSuccess && ! isCompleted) // ne çıkarsa tersi çıkacak
            {
                Console.WriteLine("Fine");
            }
            // İLİŞKİSEL OPERATÖRLER:
            // ==, <, >, !=, >=, <= 
            // Eşittir, küçüktür, büyüktür, eşit değildir, büyük eşittir, küçük eşittir.
            int a = 3;
            int b = 4;
            bool sonuc = a < b; // yani a küçük b ise true.
            Console.WriteLine(sonuc);
            sonuc = a>b; // C#'da ilk atamadan sonra değer değişimi böyleydi.
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            // ARİTMETİK OPERATÖRLER:
            // +, -, *, /, %, ++, --
            //
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2; 
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++; // sayıyı 1 arttır.
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1--; // sayıyı 1 azalt
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 % sayi2; // kalanını göster.
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
        }
    }
}