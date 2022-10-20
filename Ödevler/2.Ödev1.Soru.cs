using System;
using System.Collections.Generic;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Koleksiyonlar soru1:

            Console.WriteLine("20 tane poazitif sayı girmen gerek lütfen teker teker gir.");

            ArrayList enters = new ArrayList();
            
            for (int ct = 0; ct < 20; ct++)
            {
                Console.WriteLine($"Lütfen {ct + 1}. sayıyı giriniz:  ");
                bool cse = Int32.TryParse(Console.ReadLine(), out int num);

                if (num < 0)
                {
                    Console.WriteLine("Hatalı giriş! Negatif sayı girmeyiniz.");
                    break;
                }
                else if (! cse)
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sadece Numerik giriş yapınız.");
                    break;
                }
                else
                {
                    enters.Add(num);
                }
            }

            ArrayList Asal = new ArrayList();
            ArrayList Degil = new ArrayList();

            foreach (var item in enters)
            {
                ArrayList Bolenler = new ArrayList();

                for (int c = 1; c <= Convert.ToInt32(item); c++)
                {
                    if (Convert.ToInt32(item) % c == 0)
                    {
                        Bolenler.Add(c);
                    }
                }

                if (Bolenler.Count == 2)
                {
                    Asal.Add(Convert.ToInt32(item));
                }
                else
                {
                    Degil.Add(Convert.ToInt32(item));
                }
            }

            Console.WriteLine($"Girdiğiniz sayılardan {Asal.Count} kadarı asal sayıdır.");
            Console.WriteLine($"Girdiğiniz sayılardan {Degil.Count} kadarı asal sayı değildir.");

            int DegilToplam = 0;

            int AsalToplam = 0;

            foreach (var item in Asal)
            {
                AsalToplam += Convert.ToInt32(item);
            }
            foreach (var item in Degil)
            {
                DegilToplam += Convert.ToInt32(item);
            }

            int AsalOrtalama = AsalToplam / Asal.Count;
            int DegilOrtalama = DegilToplam / Degil.Count;

            Console.WriteLine($"Girdiğiniz asal sayıların aritmetik ortalaması {AsalOrtalama}'dır.");
            Console.WriteLine($"Girdiğiniz asal olmayan sayıların aritmetik ortalaması {DegilOrtalama}'dır.");

            Asal.Sort();
            Asal.Reverse();
            Degil.Sort();
            Degil.Reverse();
            Console.WriteLine("*** Asallar ***");
            foreach (var item in Asal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*** Asal olmayanlar ***");
            foreach (var item in Degil)
            {
                Console.WriteLine(item);
            }
        }
    }
}