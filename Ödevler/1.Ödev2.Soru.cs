using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("'parametre,parametre' şeklinde integer girdi yapın lütfen: ");
            string liste = Console.ReadLine();
            string[] liste1 = liste.Split(",");

            int sayi1 = Convert.ToInt32(liste1[0]);
            int sayi2 = Convert.ToInt32(liste1[1]);

            int[] nums = new int[sayi1];

            for (int i = 0; i < sayi1; i ++)
            {
                Console.Write("{0}. sayıyı giriniz: ", (i+1));
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var num in nums)
            {
                if (num == sayi2)
                {
                    Console.WriteLine(num);
                }
                else if (sayi2 % num == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}