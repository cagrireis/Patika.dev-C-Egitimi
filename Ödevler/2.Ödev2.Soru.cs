using System;
using System.Collections.Generic;
using System.Collections;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet sayı gireceksiniz lütfen sadece numerik sayı giriniz.");

            int[] nums = new int[20];

            for (int ct = 0; ct < 20; ct++)
            {
                Console.Write($"Lütfen {ct + 1}. sayıyı giriniz: ");
                nums[ct] = Convert.ToInt32(Console.ReadLine());
            }

            int [] shorts = new int[3];
            int [] longs = new int[3];

            Array.Sort(nums);

            for (int ct = 0; ct < 3; ct ++)
            {
                shorts[ct] = nums[ct];
            }

            Array.Reverse(nums);

            for (int ct = 0; ct < 3; ct ++)
            {
                longs[ct] = nums[ct];
            }

            Console.WriteLine("Girdiğiniz en büyük 3 sayı:");

            foreach (var item in longs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Girdiğiniz en küçük 3 sayı:");

            foreach (var item in shorts)
            {
                Console.WriteLine(item);
            }

            int buyuktoplam = 0;
            int kucuktoplam = 0;

            foreach (var item in shorts)
            {
                kucuktoplam += item;
            }

            foreach (var item in longs)
            {
                buyuktoplam += item;
            }

            Console.WriteLine($"Girdiğiniz sayılardan en küçük 3 tanesinin toplamı {kucuktoplam}'dır.");
            Console.WriteLine($"Girdiğiniz sayılardan en büyük 3 tanesinin toplamı {buyuktoplam}'dır.");

            int kucukortalama = kucuktoplam / 3;
            int buyukortalama = buyuktoplam / 3;

            Console.WriteLine($"Girdiğiniz sayılardan en küçük 3 tanesinin aritmetik ortalaması {kucukortalama}'dır.");
            Console.WriteLine($"Girdiğiniz sayılardan en büyük 3 tanesinin aritmetik ortalaması {buyukortalama}'dır.");
        }
    }
}