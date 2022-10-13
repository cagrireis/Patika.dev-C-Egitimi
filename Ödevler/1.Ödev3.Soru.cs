using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girdiğiniz sayı kadar kelime gireceksiniz. Pozitif bir sayı girin: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[num];

            for (int ct = 0; ct < num; ct++)
            {
                Console.Write("Lütfen {0}. kelimenizi giriniz: ", (ct + 1));
                words[ct] = Console.ReadLine();
            }

            Array.Reverse(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}