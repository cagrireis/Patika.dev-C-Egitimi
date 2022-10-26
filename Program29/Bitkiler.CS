using System;
namespace MyApp
{
    public class Bitkiler:Canlılar // bu şekilde kalıtımı dağıttık.
    {
        protected void fotosentez()
        {
            Console.WriteLine("Canlılar fotosentez yapar.");
        } // şimdi de mirasa bakmaya başlayalım tohumlu ve tohumsuz bitkileri yazalım.
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.fotosentez(); // bunun gibi base. ifadesi ile üst sınıflardaki fonksiyonları işaret etmeliyiz.
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohum ile çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.fotosentez();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler spor ile çoğalır.");
        }
    }
}