using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arraylistler, arraylistler bir kolleksiyon listi.
            // System.Collections namespace

            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('Ç');

            // verilere erişim:

            Console.WriteLine(liste[1]);

            foreach (var i in liste)
            {
                Console.WriteLine(i); // python ile tıpa tıp aynı
            }

            // AddRange

            Console.WriteLine("*** AddRange ***");


            string[] renkler = {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1, 8, 3, 7, 9, 92, 5}; // bu şekilde liste içerisine gene gönderebiliriz.
            liste.AddRange(renkler);
            liste.AddRange(sayılar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Sort

            Console.WriteLine("***** Sort *****");

            // liste.Sort(); // bu hata döndürecektir. çünkü farklı veri tipleri var.

            ArrayList liste2 = new ArrayList();

            List<int> sayilar2 = new List<int>(){1, 5, 6, 78, 98, 3, 45, 6, 7, 4, 3};

            liste2.AddRange(sayilar2);

            liste2.Sort(); // burada bir sıkıntı olamdan sıraladı.

            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }

            // Binary Search

            // binary search kullanmak için öncelikle kullancağımız listeyi sıralamamız gerekiyor.

            Console.WriteLine(liste2.BinarySearch(4)); // bakın getirdi eğer genericlerde sıralamadan yaparsak -2 döndürür.

            // reverse

            liste2.Reverse();

            foreach (var item in liste2) // büuükten küçüğe veya tam tersi bu şekilde yapılabilir.
            {
                Console.WriteLine(item);
            }

            // clear 

            // listeyi temizler.

            liste2.Clear();

            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }
        }
    }
}