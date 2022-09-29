using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sort (sıralama işlemi):

            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};
            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***** Sıralı Dizi *****");
            Array.Sort(sayiDizisi); // verdiğim dizi üzerinde değiştirir yani başka bir değişene atama ihtiyacı yok. Aynı Python gibi. Küçükten büyüğe sıralar aynı python gibi.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi); // küçükten büyüğe.
            }

            // Clear methodu.
            // bir dizide verdiğimiz indexten başlayarak belli indexe kadar değerleri 0lıyor.
            Console.WriteLine("***** ARRAY CLEAR *****");
            // sayidizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,2); // obje, başlama indexi, silinen eleman sayısı.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);  // 2. indexten itibaren 2 tane elemana 0 değeri atadı.
            }

            // reverse (ters çevirme):

            Console.WriteLine("***** Array Reverse *****");

            Array.Reverse(sayiDizisi); // ters çevirdi.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi); 
            }

            // indexOf içine girdiğimiz elemanın eğer dizi içinde varsa indexini döner.

            Console.WriteLine("***** IndexOf *****");

            Array.IndexOf(sayiDizisi, 23); // sayidizisi dizisinde 23 değerindeki elemanın indexini döndürdü bize.

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23)); // 23 2. idnexte. ve onu döndürdü.

            // Resize (yeniden boyutlandırma):

            Console.WriteLine("***** ARRAY RESIZE *****");

            Array.Resize<int>(ref sayiDizisi, 9); // aslında burada 8 boyutluyu 9 a çıkardık. int tipi olduğunu belli ettik referans diziyi girdik ve kaça çıkaracağımızı ,'den sonra yazdık.

            sayiDizisi[8] = 99; // 8. indexteki 9. elemanı 99 yaptık ilk atadığımızda 0'dı çünkü.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi); 
            }
        }
    }
}