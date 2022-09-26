using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine(time);
            if(time >= 6 && time < 12) // kodlar yukarıdan aşağıya akar.
            {
                Console.WriteLine("Günaydın!");
            }
            else if(time >= 12 && time < 18)
            {
                Console.WriteLine("İyi Günler!");
            }
            else if(time >= 18 && time < 21)
            {
                Console.WriteLine("İyi Akşamlar!");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            // bunu kat kat değil de alt alta yazdırma:

            string sonuc = time <= 18 ? "İyi günler": "İyi geceler"; // yani normal tanımlıyoruz ancak eşitliğin sağına koşul giriyoruz soru işareti yazıyoruz ve ondan sonra ne olacağını giriyoruz ":"'dan sonraki kısım else kısmı.
            Console.WriteLine(sonuc);

            // peki çift if ile nasıl yazabliriz?

            sonuc = time >= 6 && time <= 12 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler"; // daha önce tanımladığımız için sadece değer güncelleme yapıyoruz. ilk koşulu yazdık ? den sonra sağlanırsa ne olacağını yazdık ilk : else if yerini tutar. sonrasında yine ? ve sağlanırsa olmasını istediğimiz.
            Console.WriteLine(sonuc); 
        }
    }
}