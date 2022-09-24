using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir değişkenin bir değeri olmalı.
            int deger;
            deger = 2;
            Console.WriteLine(deger);
            // veya şu şekilde
            int deger2 = 8;
            // eğer o an bir değer veremeyeceksek null da atabiliriz.
            string degisken1 = null;
            // büyük küçük harf sensivity si vardır.
            // harf ile başlayamaz.
            // aynı kod bloğunda 2 aynı değişken tanımlanamaz.
            // işlem operatörü içeremez.
            // boşluk da olmaz.
            //-----------------------------------------------------------------------------------------------------------
            // stringler:
            // STRİNG VERİ TİPİ:
            String degisken2 = " "; // bu boş değil.
            if (degisken2 == ""){
                Console.WriteLine("Boşluktur.");
            }
            // Aynı zamanda stringlere de null atanabilir.
            // CHAR VERI TIPI:
            // CHARLAR BELLEKTE 2 BYTE YER TUTARKEN STRINGLER YAZDIĞIMIZA GÖRE SINIRSIZ YER TUTAR.
            // Ancak char tek bir karakter tutabilir tek bir harf gerekliyse char kullanırız.
            char ch = '2'; // ATRICA CHARLAR TEK PARANTEZDİR.
            string stri = "Selam";
            //---------------------------------------------------------------------------------------------------
            // TAM SAYILAR:
            // BYTE VERİ TİPİ:
            // Byte bellekte 1 byte veri tutar bir de sbyte lar vardır.
            // sbyte lar da 1 byte yer tutar
            // sbyte -128'den 127'ye, byte'lar -256'dan 255'e kadar değer alabilir.
            sbyte sbit = 110;
            byte bit = 6;
            // SHORT VERİ TİPİ:
            short kisa = 1000;
            // 2 byte yer tutar.
            // -32768'den 32767'ye kadar değer tutabilir.
            // bunların hepsi tam sayı.
            // UNSİGNED SHORT:
            ushort ukisa = 30000;
            // bellekte bu da 2 byte yer tutar
            // 0'dan 65365 arasındaki değerlerden alabilir.
            // shortlar çok kullanılır.
            // İNTEGERLARA GELİRSEK;
            // İ16:
            Int16 i16 = 2; // 2 byte yer tutar
            int i = 2; // bellekte 4 byte yer kaplar.
            Int32 i32 = 2; // 4 byte yer kaplar
            Int64 i64 = 2; // 8 byte kaplar
            // intler gittikçe daha fazla yer kaplar en çok int 64 kaplar.
            // UNSİGNED İNT
            uint ui = 32; // 4byte yer kaplıyor.
            // Long
            long l = 4; // 8byte yer tutar.
            // genelde çok büyük sayılar için kullanılır.
            // Unsigned long:
            ulong ul = 64; // long ile aynı büyüklükte yer kaplar.
            //-------------------------------------------------------------------------------------
            // REEL SAYILAR:
            // Float veri tipi:
            float f = 72; // 4 byte yer tutar.
            // reel sayılar için kullanılabilir.
            // DOUBLE veri tipi:
            double d = 5; // 6 byte yer tutar bu da reel sayı tutar.
            // DECIMAL VERI TIPI:
            decimal de = 3; // 16 byte yer tutar.
            //--------------------------------------------------------------------------------------------------
            // MANTIKSAL DEĞERLER:
            // BOOL VERİ TİPİ
            bool b1 = true;
            bool b2 = false;
            //--------------------------------------------------------------------------------------
            // DATETIME VERI TIPI:
            // O ANIN TARİH VE SAATİNİ TUTAR VE KÜTÜPHANEDEN ÇALIŞIR.
            DateTime DT = DateTime.Now;
            Console.WriteLine(DT); // evet çalışıyor.
            //----------------------------------------------------------------------------------------------
            // OBJELER:
            // obje yapısı veri tiplerinden bağımsız değer tutabilir.
            object o1 = 'c';
            object o2 = "Çağrı";
            object o3 = 23;
            object o4 = 2.3;
            object o5 = DateTime.Now;
            // bütün değişken tipleri birer objedir.
            // mantığı buradan gelir.
            // her şeyi tutabilir.
            //----------------------------------------------------------------------------
            // STRING İŞLEMLERİ:
            string str1 = ""; // Boş string tutar.
            string str2 = null; // Boş string tutar.
            string str3 = string.Empty; // Boş string tutar.
            str2 = "Çağrı REİS"; // burada yaptığımız üzerine değer atamak zaten o string tanımlanmıştı.
            string isim = "Çağrı";
            string soyisim = "REIS";
            string tamisim = isim + " " + soyisim;
            Console.WriteLine(tamisim);
            //---------------------------------------------------------------------------
            // Integer İşlemleri:
            int in1 = 5;
            int in2 = 3;
            int in3 = in1 * in2;

            // boolean 
            bool bo1 = 10 < 2; // mantıksal olarak bool atama da böyle.
            //--------------------------------------------------------------------------------
            // DEĞISKEN DONUSUMLERİ:
            string str20 = "20";
            int int20 = 20;
            // bu iki ifadeyi string olarak birleştirip yeni bir değer elde etmek istiyorsak
            string yenideger1 = str20 + int20.ToString(); // bu birinc yöntem böyle çevrilebilir. 2020 çıktı olması gerektirği gibi.
            string yenideger2 = str20 + Convert.ToString(int20); // bu da 2. yolu.
            Console.WriteLine(yenideger1);
            //-----------------------------------------------------------------------------------------
            // Integer işlemleri:
            int int21 = int20 + Convert.ToInt16(str20); // bu şekilde evrensel dönüşüm fonksiyonu olştu.
            Console.WriteLine(int21);
            // Başka bir dönüşüm yöntemi daha:
            int int22 = int20 + int.Parse(str20); // 40 çıktısı.
            Console.WriteLine(int22);
            // datetime'a yakından bakalım.
            string dt2 = Convert.ToString(DateTime.Now);
            Console.WriteLine(dt2);
            // bu date time olayını aralarında istediğimiz işaret ile ve farklı yol ile getirmek:
            string dt3 = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm"); // saatler.
            Console.WriteLine(dt3);
            Console.WriteLine(hour);
        }
            
    }
}