using System;

namespace arayuzler_ornek
{
    internal class Program
    {
        static void Main(string[] args) // abstract classlar kalıtım için kullanılan classlar gibidir. Bazı özellikleri ile sınıflara çok benzerken bazıları ile interfaceye benzer.
        // new anahtar kelimesi ile türetilemezler. tek başlarına anlamlı değildir. method bildirimi yapılabilir. abstract classın içindeki abstract methotlar override edilmek zorunludur.
        // bir önceki örneğin dosyasından çalışıyoruz çünkü orası verimli.
        { // 3 otomobil classı yaratmak için marka sttandart renginin kaç tekerlekten oluşan 3 metot ile interface oluşturacağız.
            Console.WriteLine("Hello World!");

            focus Focus = new focus();
            Console.WriteLine(Focus.HangiMarkanınAracı()); // çalıştı
            Console.WriteLine(Focus.KacTekerlektenOlusur());
            Console.WriteLine(Focus.StandartRengiNe());

            Console.WriteLine("****************************************************************************************");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAracı());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe());

            Console.WriteLine("****************************************************************************************");

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkanınAracı());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe());

            Console.WriteLine("************************************************* ABSTRACT CLASS KISMI ***********************************************************");

            NewFocus newfocus = new NewFocus();
            Console.WriteLine(newfocus.HangiMarkanınAracı()); 
            Console.WriteLine(newfocus.KaçTekerlektenOlusur());
            Console.WriteLine(newfocus.StandartRengiNe());
            Console.WriteLine("*****************************************************************************************");
            NewCivic newcivic = new NewCivic();
            Console.WriteLine(newcivic.HangiMarkanınAracı());
            Console.WriteLine(newcivic.KaçTekerlektenOlusur());
            Console.WriteLine(newcivic.StandartRengiNe());
            Console.WriteLine("*****************************************************************************************");
            NewCorolla newcorolla = new NewCorolla();
            Console.WriteLine(newcorolla.HangiMarkanınAracı());
            Console.WriteLine(newcorolla.KaçTekerlektenOlusur());
            Console.WriteLine(newcorolla.StandartRengiNe());

            // son ders..
        }
    }
}