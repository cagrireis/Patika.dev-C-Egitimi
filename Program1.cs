using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("İsminizi öğrenebilir miyim?");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi öğrenebilir miyim?");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
            
    }
}