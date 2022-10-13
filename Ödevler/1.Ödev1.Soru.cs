using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            Console.Write("Lütfen içinden çift sayıların ayıklanıp ekrana basılacağı kadar sayı gireceğinizden kaç adet sayı gireceğinizi giriniz: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[num];

            for (int count = 0; count < num; count ++)
            {
                Console.Write("Lütfen {0}. elemanı giriniz: ", (count + 1));
                nums[count] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var element in nums)
            {
                if (element % 2 == 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}