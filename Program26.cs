using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // struct (yapı) kavramı
            // sınıflara çok benzerler kendine ait yapıcıları vardır propertyleri vardır.
            // sınıfar referans tipinde bir tiptir. value tipinde (değer) tipinde structlar'dır.
            // referans tipindekiler heap bölgesinde tutuluyordu. value tipleri ise belleğin stack bölgesine tutuluyorlar.
            // referans'da sadece heap'teki verinin adresini tutan bilgi stackte tutulur.
            // genel olarak benzerler


            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.KisaKenar = 3;
            dikdörtgen.UzunKenar = 4;

            Console.WriteLine("Diködrtgen alan hesabı: {0}.",dikdörtgen.AlanHesapla());

            DikDörtgen_Struct dikdörtgens = new DikDörtgen_Struct();

            dikdörtgens.UzunKenar = 4;
            dikdörtgens.KisaKenar = 3;
            
            Console.WriteLine("Dikdörtgen struct'ın alan hesabı: {0}", dikdörtgens.AlanHesapla());

            // struct'ın birkaç farkı var mesela bir struct'ı lu şekilde de oluşturabiliriz:

            DikDörtgen_Struct dikdörtgenst; // bu şekilde de oluşturabiliriz.

            dikdörtgenst.KisaKenar = 200;
            dikdörtgenst.UzunKenar = 600;
            Console.WriteLine("2. şekilde oluşturulmuş dikdörtgenin alanı: {0}'dır.", dikdörtgenst.AlanHesapla());

            // sınıflar ile constructer konusunda farka düşerler. Aşağıdan izlenebilir.

            // bir başka fark ise bir nesne oluşturulduğunda nesnenin içindeki özelliklere değer atanmasa da özelliklerin değerleri ile işlem yapan fonnksiyon çağrılabilir. Fakat default değerleri döndürür.
            // Ancak yuakrıdaki özellik sadece new ile çağrıldığında yapılabilir. yoksa kendimiz atamamız gerekir.

            // class ve struct kullanımı artı ve eksileri:
            // 16 byte a kadar veriler için structlar kullanın 16 byte dan büyük ise class kullanın.
        }
    }

    class Dikdörtgen // bu class
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }

        public Dikdörtgen() // bunu classlarda yapabiliyoruz. Ancak structlarda parametresiz constructer tanımlayamayız.
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
    }

    struct DikDörtgen_Struct
    {
        // paramtresiz konstraktör tanımlayaamayız.
        public int KisaKenar;

        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.UzunKenar * this.KisaKenar;
        }

        public DikDörtgen_Struct(int kenar1, int kenar2) // buna izin veriyor.
        {
            this.UzunKenar = kenar1;
            this.KisaKenar = kenar2;
        }
    }
}