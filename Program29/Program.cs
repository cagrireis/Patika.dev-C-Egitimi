using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kalıtım (Inheritence)
            //              Canlılar
            //                  |
            //      Bitkiler            Hayvanlar
            //    |           |        |            |
            // Tohumlu       Tohumsuz   Surungenler   Kuşlar

            // Bir üst sınıfın alt sınıfa kalıtım vermesidir.

            // bir alt sınıfın üst sınıfın bazı özelliklerinin kendinin de kullanması gibi.

            // bitkiler de hayvanlar da canlı fakat kendi içlerinde farklı özellikleri var.
            // bitkilerde tohumluların ve tohumsuzların ortak özellikleri var fakat içinde farklı özellikleri de var. Özünde bitkidir ama.
            // bunu yazılıma dökelim.

            TohumluBitkiler TohumluBitki = new TohumluBitkiler();
            //TohumluBitki.Beslenme();
            //TohumluBitki.Boşaltım();
             // burası erişilemiyor. protected yapınca. constructer varsayımı kurucu metodunu yazmalıyız içine.
            //TohumluBitki.Solunum();
            TohumluBitki.TohumlaCogalma(); // inheritence aldığımız sınıfların da fonksiyonları geldi.

            Console.WriteLine("*****************");

            Kuşlar Martı = new Kuşlar();
            // Martı.Beslenme();
            //Martı.Boşaltım();
            //Martı.Uçmak();
            //Martı.Solunum(); // aynı durum burası için de geçerli.

            // ancak biz hata yaparak her sınıfı protected yaptık.
            // biz sadece inheritence için kullandığımız protected adlı erişim belirtecini kullanabiliriz.

            // *** kısacası biz protected yaptıktan sonra base. ile kurucu içerisine yazmalıyız. yoksa erişim kısıtlanır.
            // ayrıca base. ile kurucu olduğundan her nesne oluşumunda çağrılır ve anında erişiriz ve güvenlikli olur.
            // base. dan sonra martı.Beslenme() işe yaramz base. ile kurucu ile çağrılır.
        }
    }
}