using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp. Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp.";

            // lenght fonksiyonu. Bu library fonksiyon ile ne kadar elemanı olduğunu bastırabiliriz.
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower. ilgili stringin tüm karakterlerini ya büyütür ya da küçültür.

            Console.WriteLine(degisken.ToUpper()); // büyütür 
            Console.WriteLine(degisken.ToLower()); // küçültür

            // Concat. 2 veya daha fazla parametre alır ilki bizim argümanımızdiğeri birleştirmek istediğimiz stringdir.
            Console.WriteLine(string.Concat(degisken, " ", "Merhaba. ", "Ben Çağrı REİS."));

            // Compare, CompareTo.
            // CompareTo, 2 adet argüman alır ve birinci ikinciye büyüklük anlamında eşitse 0 döndürür. Eğer 1. büyükse 1 döndürür 1. daha küçükse -1 döndürür.

            Console.WriteLine(degisken.CompareTo(degisken2)); // 1 daha uzun bir string o yüzden 1 döndü.

            // Compare ise string. ile erişilir ve 2 argüman bir ignore case alır. yani string.Compare yazarız () içine karşılaştırılacak argümanları girip sonra true veya false gireriz yani büyük harf duyarlı olsun ise true değil ise false.

            string exa1 = "Sa";
            string exa2 = "sa";

            Console.WriteLine(string.Compare(exa1, exa2, true)); // 0 döndü
            Console.WriteLine(string.Compare(exa1, exa2, false)); // 1 döndü.

            // contains
            // önce yazılan argümanın içinde 2. yazılan argüman var mı diye kondtrol ediyoruz.

            string exa3 = "C#";
            string exa4 = "C# öğreniyorum.";
            string exa5 = "nru";

            Console.WriteLine(exa4.Contains(exa3)); // true 
            Console.WriteLine(exa4.Contains(exa5)); // false

            // endswith, startswith
            // değişkenin ne ile başlayıp bittiğini sorgulama.

            Console.WriteLine(exa4.StartsWith("C#"));
            Console.WriteLine(exa4.EndsWith("öğreniyorum."));
            Console.WriteLine(exa4.EndsWith("."));

            // IndexOf
            // girilen argümandan sonra girilen ifadenin bulunurluğunu argümanın içinde arar varsa aranılan ifadenin ilk elemanının indexini döndürür. bulamazsa -1 döndürür.
            Console.WriteLine(exa4.IndexOf("öğreniyorum")); // ö üçüncü indexte
            Console.WriteLine(exa4.IndexOf("öğreniyot")); // bulamadı -1 döndürdü.

            // Insert
            // bir start indexi alır ve , koyup yazdığınız ifadeyi o indexten itibaren oraya yapıştırır.
            Console.WriteLine(exa4.Insert(2, " Nasılsın? "));

            // LastIndexOf
            // diyelim ki bir stringde birden fazla bir ifade var stringdeki bahsi geçen en son ifadeyi getirir.
            Console.WriteLine(degisken.LastIndexOf("i")); // "i"' nin en sonda olanının indexini getirdi.

            // PadLeft ve PadRight;
            // left olan soluna girilen sayının uzunluğunu argüman uzunluğu ile birlikte uzunluğu tamamlayacak kadar boşluk koyar right olan ise sağına kaoyar.

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(40) + degisken2);
            Console.WriteLine(degisken + degisken2.PadLeft(50, 'a')); // veya boşluk yerine argüman da girebiliriz.
            Console.WriteLine(degisken.PadRight(50, '*') + degisken2.PadLeft(50, '*'));

            // Remove
            // start indexten itibaren sonuna kadar siler. eğer virgül ile ikinci girdiyi yaparsak ikinci girdi indexine kadarki kısmını sileriz.
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(0,1));

            // Replace
            // stringin içindeki ifadeyi yazıp virgülden sonra o ifadenin yerine hangi ifade yazılacak onu gireriz.
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            // split 
            // stringi girdiğimiz değere göre bulunduğu noktaları parçalayıp bir diziye atar. bunu bir değişkene eşiteleyebiliriz ya da hemen sonra [] ile bir index parçasını çağırabiliriz.
            
            Console.WriteLine(degisken.Split(' ')[1]);

            // substring
            // bir idnex gireriz ikinci girilen kadar uzunlukta kısmı getirir. Eğer 2. index girmezsek sonuna kadar getirir.

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}