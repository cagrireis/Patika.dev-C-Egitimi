using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // datetime ve math metotları (library)
            Console.WriteLine(DateTime.Now); // tarihi saati ile birlikte getirir.
            Console.WriteLine(DateTime.Now.Date); // yalnız tarih gelir saat 00:00:00 gelir.
            Console.WriteLine(DateTime.Now.Day); // gün
            Console.WriteLine(DateTime.Now.Month); // ay
            Console.WriteLine(DateTime.Now.Year); // yıl
            Console.WriteLine(DateTime.Now.Hour); // saat
            Console.WriteLine(DateTime.Now.Minute); // dakika
            Console.WriteLine(DateTime.Now.Second); // saniye

            Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın gününü string alini getirir.
            Console.WriteLine(DateTime.Now.DayOfYear); // yılın kaçıncı gününde olduğumuzu getirir.
            Console.WriteLine(DateTime.Now.ToLongDateString()); // bunda uzun uzun yazarak tarih getirir
            Console.WriteLine(DateTime.Now.ToShortDateString()); // bunda sayılar ile ifade eder.
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // Saniye de getirir 
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // saniye getirmez

            // Add metotları:

            Console.WriteLine(DateTime.Now.AddDays(2)); // bunlar ekleme fonksiyonlarıdır.
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime formatları
            // saturday yerine sat yazsın vb gibi isteklerimiz olabilir.

            Console.WriteLine(DateTime.Now.ToString("dd")); // 24 saatlik hali
            Console.WriteLine(DateTime.Now.ToString("ddd")); // 3 harflik halini getirir. Kısaltmasını yani
            Console.WriteLine(DateTime.Now.ToString("dddd")); // ttam halini getirir.

            Console.WriteLine(DateTime.Now.ToString("MM")); // numerik ay ifadesini getirir.
            Console.WriteLine(DateTime.Now.ToString("MMM")); // kısaltma getirir.
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // tam ay adını getirir.

            Console.WriteLine(DateTime.Now.ToString("yy")); // son iki kısmını getirir.
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // tamamını getirir.


            // Math Kütüphanesi:

            Console.WriteLine(Math.Abs(-79)); // mutlak değer.
            Console.WriteLine(Math.Sin(78.2)); // sinus alır.
            Console.WriteLine(Math.Cos(-28)); // cosinus
            Console.WriteLine(Math.Tan(28)); // tanjant
            Console.WriteLine(Math.Ceiling(22.3)); // girilen sayıdan büyük en küçük tam sayıyı getirir. Burada 23.
            Console.WriteLine(Math.Round(22.3)); // Burada yuvarlar.
            Console.WriteLine(Math.Floor(22.7)); // girilen sayıdan küçük en büyük tam sayıyı getirir.
            Console.WriteLine(Math.Max(2,6)); // max getirir.
            Console.WriteLine(Math.Min(2,6)); // min getirir.
            Console.WriteLine(Math.Pow(3,4)); // kuvvetini alır burada 3 üzeri 4 işlemini yapar.
            Console.WriteLine(Math.Sqrt(9)); // karekök alır.
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki log karşılığı.
            Console.WriteLine(Math.Exp(3)); // 3 üzeri 3 döndürür.
            Console.WriteLine(Math.Log10(100)); // log 10 tabanında karşılık.
        }
    }
}