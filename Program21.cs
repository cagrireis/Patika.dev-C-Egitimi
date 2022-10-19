using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dictionaryler koleksiyon altında bulunur
            // key value pairlarından oluşurlar

            // keyler kendine has olmalı aynı iki key olmamalı.
            // System.Collections.Generics.

            Dictionary<int,string> kullanicilar = new Dictionary<int, string>(); // tanımlarken <> içine ilk key tipi , value tipi yazılmalıdır.
            kullanicilar.Add(10, "Ayşe Yılmaz"); // Add ile eleman eklenir, iki parametre alır. ilki key ikincisi value'dir.
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            // elemanlarına erişim:

            Console.WriteLine("*** Elemanlara Erişim ***");

            Console.WriteLine(kullanicilar[12]); // tek elemana erişim yine python gibi [] içerisine key yazılır ve value gelir.

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item); // key ve valueleri [] içerisinde bastırır.
            }

            // Count

            Console.WriteLine(kullanicilar.Count); // listlerdeki gibi 

            // Contains

            // iki tip Contains vardır bir dictionary olduğundan;

            Console.WriteLine(kullanicilar.ContainsKey(12)); // burada keyleri sorgularız.
            Console.WriteLine(kullanicilar.ContainsValue("Ayşe Yılmaz")); // Burada valueleri sorgularız.

            // Remove

            Console.WriteLine("*** Remove ***");
            Console.WriteLine(kullanicilar.Remove(12)); // key girilerek o eleman çıkarılır.
            foreach (var items in kullanicilar)
            {
                Console.WriteLine(items); // kaldırıldı.
            }

            // Keys
            // Values

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("*** Values ***");

            foreach (var item in kullanicilar.Values) // bu şekilde de valuelere ulaşılabilir
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*** Keys ***");

            foreach (var item in kullanicilar.Keys) // bu şekilde de keylere ulaşılabilir.
            {
                Console.WriteLine(item);
            }
        }
    }
}