using System;

namespace MyApp
{
    internal class Problem
    {
        public static void Main(string[] args)
        {
            // aynı tipteki değişkenleri bellekte arka arkaya sıralamaktır. sadece tek değerde tutar.
            // python gibi 0. elemandan başlar indexing anlamında.

            // dizi tanımlama

            string[] renkler = new string[5]; //5 elemanlı stringlerden oluşan adı renkler olan dizi tanımladık.

            string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"}; // burada bizzat diziyi biz yazdık.

            int[] dizi; // Bu ve bir aşağıdaki satır ise dizinin başka bir tanımlama yöntemi
            dizi = new int[5]; // diziyi başta tanımladık fakat ne değer atadık ne de sayısını girdik daha sonra hallettik.

            // Dizilere değer atama ve erişim:

            renkler[0] = "Mavi"; // python ile aynı. 0. indexe "Mavi" değerini atadık.
            Console.WriteLine(hayvanlar[0]); // 0. indexinde kedi var.
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[0]); // Değer atamadığımız bir int dizisi elemanı çağrılırsa 0 oalrak gelir.
            Console.WriteLine(dizi[1]); // Değer atamadığımız bir int dizisi elemanı çağrılırsa 0 oalrak gelir.
            Console.WriteLine(dizi[2]); // Değer atamadığımız bir int dizisi elemanı çağrılırsa 0 oalrak gelir.

            // Döngüler ile dizi kullanımı
            // kullanıcıdan n tane girdi alıcam ve o girdilerin ortalamasını bastırıcam.

            Console.Write("Lütfen ortalaması alınacak dizinin boyutunu girin: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] sayiDizisi = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1 ); // python formatting ile aynı {} içerisine sayısını yaz ve sırası ile , den sonra doldur.
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine()); // bu aslında tek forda çözülebilir ancak foreach de kullanmak istiyoruz.
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Girdiğiniz değerlerin ortalaması: " + (toplam / size) + "'dır."); 

            // yukarıdakinin hızlısını ben yapıcam şimdi:

            Console.Write("Program için gerekli olan ortalaması bulunacak olan dizinin uzuluğunu girin: ");

            int longness= Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[longness];

            int toplam1 = 0;

            for (int count = 0; count < longness; count ++ )
            {
                Console.Write("Lütfen dizinin {0}. elemanını girin: ", count + 1);
                int entery = Convert.ToInt32(Console.ReadLine());
                toplam1 += entery;
                nums[count] = entery;
            }
            Console.WriteLine("Girdiğiniz sayılar sonucunda ortalaması {0}'dır.", (toplam1 / longness));
        }
    }
}