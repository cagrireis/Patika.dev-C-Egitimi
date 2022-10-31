using System;

namespace arayuzler_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        { // 3 otomobil classı yaratmak için marka sttandart renginin kaç tekerlekten oluşan 3 metot ile interface oluşturacağız.
            Console.WriteLine("Hello World!");

            focus Focus = new focus();
            Console.WriteLine(Focus.HangiMarkanınAracı()); // çalıştı
            Console.WriteLine(Focus.KacTekerlektenOlusur());
            Console.WriteLine(Focus.StandartRengiNe());

            Console.WriteLine("***************************************************************************************");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAracı());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe());

            Console.WriteLine("***************************************************************************************");

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkanınAracı());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe());
        }
    }
}