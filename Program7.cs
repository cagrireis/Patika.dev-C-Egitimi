using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch case ile yapılabilecek er şey if else ile de yapıalbilir fakat pratiklik açısından bazen switch case kullanmalıyız.
            int month = DateTime.Now.Month; // int karşılık sunar ocaksa 1 şubatsa 2 vb.
            Console.WriteLine("Aşağıdaki örnek için kontrol: " + month);
            switch (month) // bu parantez expression gireriz yani koşul. kontrol etmek istediğimiz şey budur.
            {
                case 1: // python gibi 
                    Console.WriteLine("Ocak Ayındasınız."); // bunu yazıp bırakamam biteceği yerde break kullanmalıyım.
                    break; // olmazsa olmaz.
                case 2:
                    Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 4: // sıraya uymak zorunda değiliz.
                    Console.WriteLine("Mart ayınasınız.");
                    break ;
                case 9:
                    Console.WriteLine("Eylül ayındasınız.");
                    break ;
                default: // default; hiçbir case'e uymazza gelip çalışacak bloktur.
                    Console.WriteLine("Yanlış veri girişi"); // bu imkansız maa olsun.
                    break; // hiçbir şey yapmak istemiyorsak break ifadesi ile kırabiliriz. Break kullanırız switch case'de.
            
            }
            // bazen birden çok case ifadesini aynı blokta çalışmasını isteyebiliriz.
            // o da şu şekilde;
            switch (month)
            {
                case 12: // bu şekilde caseleri alt alta dizip benzer çıktı vermelerini sağlayabiliriz.
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız.");
                    break;
                case 3:
                case 4: // aynı case2 defa kullanılamaz.
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayındasınız.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayındasınız.");
                    break;
                default:
                break;
            }
        }
    }
}