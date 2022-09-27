using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while 
            // 1 den başlayarak consoldan alınan sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdırdan program.
            Console.Write("Bir girdi giriniz: ");
            int girdi = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int toplam1 = 0;
            while (x <= girdi) // içine bir koşul gireriz ve doğru olduğu sürece çalışır.
            {
                toplam1 += x; // her bir sayıyı toplarız belirtilen sayıya kadar.
                x += 1; // burasını koymazsam sonsuz loop olur.
            }
            Console.WriteLine("Girdiğiniz sayıya kadar olan sayıların ortalaması: " + (toplam1 / girdi) + "'dir.");

            // A'dan z'ye kadar tüm harfleri konsola yazdıralım.

            char character = 'a'; // char bir kendinden dizin galiba bir bir arttırarak alfabe yazıyoruz.
            while (character <= 'z') // z'ye gelene kadar bir bir arttırarak bastırır.
            {
                Console.Write(character);
                character ++;
            }

            // foreach döngüsü(iterasyonu):
            
            Console.WriteLine("***** FOREACH *****");

            string[] arabalar = {"BMW", "FORD", "TOYOTA", "NISSAN"}; // Dizi tanımladık. Bunun detayları bir dahaki ders.

            foreach (var araba in arabalar) // bu bir hazır foreach kalıbı ve foreach python'daki normal ilk öğretilen for için kullanılan itersyon gibi.
            { // yukarısının açıklaması: var genel bir tanımlama ifadesi kısaca arabaların içerisindeki her araba dedik yukarıda. kısaca iterasyondur genel.
                Console.WriteLine(araba); // her arabayı sırası ile yazdırdık.
            }
        }
    }
}