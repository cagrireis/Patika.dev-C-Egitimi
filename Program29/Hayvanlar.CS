using System;
namespace MyApp
{
    public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    } // sınıf isminden hemen sonra : koyarsak ona kalıtım vermeye çaılıyoruz demektir. :'den sonra yazdığımız ise miras aldığımız sınıftır.

    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void Surunme()
        {
            Console.WriteLine("Surungenler surunerek hareket ederler.");
        }
    }

    public class Kuşlar:Hayvanlar
    {
        public Kuşlar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Boşaltım();
            base.Solunum();
        }
        public void Uçmak()
        {
            Console.WriteLine("Kuşlar uçarak hareket eder."); // hem sürüngenler hem de kuşlar hayvandır bundan sebep onlaradn kalıtım almalılar o özellikleri de var.
        }
    }
}