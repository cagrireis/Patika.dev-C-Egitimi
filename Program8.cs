using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // belli kod bloğunun birden çok defa belli şarta göre çalışması için for kullanırız.
            // ekrana girilen sayıya kadar olan tek sayıları ekrana yazdıralım.
            Console.Write("Sayı giriniz: "); // write yaparsak aynı satırdan devam eder.
            int sayac = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayac; i++) // i sadece or içerisinde kullanılabilir.
            {
                // komutlar
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            int toplam1 = 0; // 2 taane erişim için toplam değişkeni tanımladık. 
            int toplam2 = 0; // burada 1 den 1000'e kadar tek ve çift sayılarının kendi içlerinde toplamını ekrana bastırmak istiyoruz.
            for (int num = 1; num <= 1000; num++) // num'u 1 yap. num 1000'e eşit veya azken devam ettir ve her seferinde num'u 1 arttır dedik.
            { // yani ilk kontrol değerimizi girdik veya tanımladık başlattık, daha sonra onun sınırını girdik, en sonda ise üzerindeki işlem ile onunla oynama noktasını girdik ve aralına ; koyduk.
                if(num % 2 == 0)
                {
                    toplam1 += num;
                }
                else{
                    toplam2 += num;
                }

            }
            Console.WriteLine("Çiftlerin toplamı: " + toplam1 + " " + "Teklerin toplamı: " + toplam2);

            // break, continue keywordleri:
            // looptan bir case'e bağlı olarak o durumda looptan çıkmak istiyorsak break kullanırız döngüyü kırar.
            // Bir şarta bağlı olarak mevcut döngünün o kısmını atlamak istiyorsak continue kullanırız o continue'den aşağısına bakmaz ve for'un solundaki yerden değerini güncelleyip güncellediği değerden devam eder.


            //bununla alakalı örnek:
            for (int k = 1 ; k <= 10; k ++)
            {
                if(k == 4) // 1, 2, 3 yazdırdık ve 4 e gelindiğinde döngüyü kırdı.
                {
                    break;
                }
                Console.WriteLine(k);
            }

            // continue ile alakalı örnek:

            for (int t = 0 ; t <= 15; t++)
            {
                if (t == 4) // 4' ü atladık continue ile."
                {
                    continue;
                }
                Console.WriteLine("in loop: " + t);
            }


            // aslında buradaki default c# loop'u python range'i gibi sonuz loop yapımı örneği:

            for (;;)
            {
                // bu bir sonsuz looptur. tehlikeli.
            }
        }
    }
}