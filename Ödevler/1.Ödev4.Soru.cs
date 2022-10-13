using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcs Func = new Funcs();
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string arg = Console.ReadLine();
            Console.WriteLine("Cümledeki toplam kelime sayısı {0}'dır. Toplam harf sayısı ise {1}'dir.", Func.words(arg), Func.ct(arg));
        }
    }

    public class Funcs
    {
        public int ct(string param)
        {
            int temp = 0;
            char boşluk = ' ';
            char nokta = '.';
            char virgül = ',';
            char kesmeIsareti = '\'';
            char soru = '?';
            foreach (var element in param)
            {
                if (String.Equals(element, boşluk) || String.Equals(element, nokta) || String.Equals(element, virgül) || String.Equals(element, kesmeIsareti) || String.Equals(element, soru))
                {
                    continue;
                }
                else
                {
                    temp += 1;
                }
            }
            return temp;
        }

        public int words(string param)
        {
            string[] liste = param.Split(" ");
            return liste.Count();
        }
    }
}