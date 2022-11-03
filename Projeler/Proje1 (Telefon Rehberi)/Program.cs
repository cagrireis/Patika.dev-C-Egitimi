using System;
using System.Collections;
using System.Collections.Generic;

namespace TelefonRehberiUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> kisiler = new Dictionary<string, int>();

            kisiler.Add("Çağrı REİS", 111119999);
            kisiler.Add("Mehmet OSMAN", 123456789);
            kisiler.Add("Süleyman İSMAİL", 2134567);
            kisiler.Add("Anıl DEMİR", 2134525645);
            kisiler.Add("Ayşe KÖMÜR", 1579435676);

            while (true)
            {
                Console.WriteLine("Telefon rehberine hoş geldiniz.");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("**********************************");
                Console.WriteLine("(1) yeni numara kaydetmek.");
                Console.WriteLine("(2) varolan numara silmek.");
                Console.WriteLine("(3) Varolan numarayı güncelle.");
                Console.WriteLine("(4) rehberi listele.");
                Console.WriteLine("(5) rehberde arama yap.");

                // ****************************************************************************************************************************

                Console.Write("Lütfen çıkan sayılardan birini tuşlayınız, Programdan çıkmak için 0'ı tuşlayınız: ");
                int islem = Convert.ToInt32(Console.ReadLine());

                if (islem == 1)
                {
                    Console.Write("Lütfen eklemek istediğiniz kişinin ismini giriniz.");
                    string kisi = Console.ReadLine();
                    Console.Write("Lütfen eklemek istediğiniz kişinin numarasını giriniz: ");
                    int numara = Convert.ToInt32(Console.ReadLine());

                    kisiler = Islemler.NumaraKaydet(kisiler, kisi, numara);

                    Console.WriteLine("İşlem tamamlandı.");
                    Console.WriteLine("Ana menüye yollanıyorsunuz....");
                }
                else if (islem == 2)
                {
                    Console.Write("Lütfen silmek istediğiniz kişinin ismini giriniz.");
                    string kisi2 = Console.ReadLine();
                    kisiler = Islemler.NumaraSil(kisiler, kisi2);
                    Console.WriteLine("İşlem tamamlandı.");
                    Console.WriteLine("Ana menüye yollanıyorsunuz....");
                }
                else if (islem == 3)
                {
                    Console.Write("Lütfen numarasını güncelleyeceğiniz kişinin ismini giriniz: ");
                    string isim3 = Console.ReadLine();
                    Console.Write("Lütfen yeni numarayı giriniz: ");
                    Int32 numara2 = Convert.ToInt32(Console.ReadLine());
                    kisiler = Islemler.NumaraGüncelle(kisiler, isim3, numara2);
                }
                else if (islem == 4)
                {
                    Islemler.Listele(kisiler);
                }
                else if (islem == 5)
                {
                    Console.Write("Lütfen arama yapacağınız kişinin ismini giriniz: ");
                    string kisi5 = Console.ReadLine();

                    Islemler.AramaYap(kisiler, kisi5);
                    Console.WriteLine("İşlem tamamlandı.");
                    Console.WriteLine("Ana menüye yollanıyorsunuz....");
                }
                else if (islem == 0)
                {
                    Console.WriteLine("Programdan Çıkılıyor.......");
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI GİRİŞ! Programdan Çıkılıyor.");
                    break;
                }
            }
        }
    }

    public static class Islemler
    {
        public static Dictionary<string, int> NumaraKaydet(Dictionary<string, int> kisiler, string isim, int numara)
        {
            Dictionary<string, int> temp = kisiler;

            temp.Add(isim, numara);

            return temp;
        }

        public static Dictionary<string, int> NumaraSil(Dictionary<string, int> kisiler, string isim)
        {
            Dictionary<string, int> temp = kisiler;

            temp.Remove(isim);

            return temp;
        }

        public static Dictionary<string, int> NumaraGüncelle(Dictionary<string, int> kisiler, string isim, int numara)
        {
            Dictionary<string, int> temp = kisiler;

            temp[isim] = numara;

            return temp;
        }

        public static void Listele(Dictionary<string, int> kisiler)
        {
            foreach (var item in kisiler)
            {
                Console.WriteLine("{0} kişisinin telefon numarası {1}'dır.", item.Key, item.Value);
            }
        }

        public static void AramaYap(Dictionary<string, int> kisiler, string isim)
        {
            foreach (var item in kisiler.Keys)
            {
                if (item == isim)
                {
                    Console.WriteLine("{0} kişisinin telefonu kayıtlı ve {1}'dir.", isim, kisiler[isim]);
                    break;
                }
                else
                {
                    Console.WriteLine("Maalesef {0} kişisinin telefonu kayıtlı bulunmuyor.", isim);
                    break;
                }
            }
        }
    }
}