using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exepction handling
            // Oluşma zamanına göre 2'ye ayrılırruntime ve compile time olarak.
            // Compile Time: Daha kod yazılırken ortaya çıkan hatalardır. Örnek olarak bir değişken tanımlanırken veri tipi atamasını yapmadıysanız derleyici kırmızı çıkarır.
            // Runtime hataları: Program çalışırken oluşan hatalardır. Bunları yakalayıp programın diğer kısmına etki etmesini önelemek lazımdır. 
            // örnek1 :
            try // Bunun içerisine hataya neden olabilecek kodu yazıyoruz.
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int x = Convert.ToInt32(Console.ReadLine()); // şimdi burası hataya açık çünkü kullanıcı bir string girerse bu çevrilemeyecek ve hata dönecek. Bunu engellemek için try catch blopu oluşturmalıyız.
                Console.WriteLine("Girmiş olduğunuz sayı: " + x); 
            }
            catch(Exception ex) // şimdi yukarıda hata gelirse onu yakalamak için catch içerisine exception yakala komutu gönderilir. Buradaki ex hataya bizim verdiğimiz isimdir.
            {
                Console.WriteLine("Hata :" + ex.Message.ToString()); // Burada ex ismini verdiğimiz hatanın mesajını .Message ile çağırırız ve onu string'e dönüştürürüz ki basabilelim.
            }
            finally // Bir koda bloğu hata versin ya da vermesin çalıştırılmasını istediğimiz bir blok varsa onu buraya yazarız.
            {
                Console.WriteLine("İşlem tamamalandı."); // jer türlü bunu döndürdü hata olursa hata mesajını da bastırdı: Input string was not in a correct format.
            } // finally zorunlu değil.
            // belli exception tipleri var biraz da onlara bakalım. Yani daha uzun yazarsanız çok uzun ufalt diye uyaranlar vb var onlara bakalım.
            // Console.WriteLine("SA");
            try
            {
                // int a = int.Parse(null); // başka bir şey deneyelim.
                // int a = int.Parse("test");
                int a = int.Parse("-222222222222222222");
            }
            catch(ArgumentNullException ex) // 1. hata buradaki hata argument null exception ve buna özel yapı var. Eğer argument null exception ise bunu yap dedik.
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex.Message); // Burada aslında direkt ex'in bır kısmını veriyor.
                Console.WriteLine(ex); // Burada ise oldukça detaylı bir yapı var. Bu büyük projelerde sorunun kaynağı açısından oldukça önemli.
            }
            catch(FormatException ex) // 2. hatada ise bu format hatasıdır çünkü alfabe sayıya çevrilemez ve biz dedik ki Format exception hatası gelirse try içinden burayı çalıştır.
            {
                Console.WriteLine("Formatı uygun değil.");
                Console.WriteLine(ex); // detaylı bir bilgi verdi.
            }
            catch(OverflowException ex) // 3. hatada çevirdiğimiz ifade çevirmeye çalıştığımız veri tipinin sınırlarını aşıyor. Buna overflow exception ddenir.
            { // overflow sıkıntısı var ise bu çalışacak.
                Console.WriteLine("Çevirmeye çalıştığınız ifade  sınırlarından çok daha büyük ya da çok küçük bir değer girdiniz.");
                Console.WriteLine(ex); // Value was either too large or too small for an Int32.
            }
            finally
            {
                Console.WriteLine("İşlem Sonlanmıştır."); // isteğe bağlı olarak bu şekilde bitirebiliriz.
            }
        }
        
    }
}