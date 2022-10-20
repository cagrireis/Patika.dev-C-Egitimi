using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle gireceksiniz ve program size o cümlenin sesli harflerini bir dizide saklayacak ve sıralayacak alfabeye göre.");

            string text = Console.ReadLine();

            string sesli = "AaBbCcÇçDdEeFfGgĞğHhIıİiJjKkLlMmNnOoÖöPpRrSsŞşTtUuÜüVvYyZzWwQqXx";

            List<char> textbook = new List<char>();

            foreach (var item in sesli)
            {
                if (text.Contains(item))
                {
                    textbook.Add(item);
                }
            }

            textbook.Sort();

            textbook.ForEach(item => Console.WriteLine(item));
        }
    }
}