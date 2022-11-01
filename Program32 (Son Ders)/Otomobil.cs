using System;

namespace arayuzler_ornek
{
    public abstract class Otomobil // böyle oluşturulur.
    {
        public int KaçTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.beyaz;
        }

        public abstract Marka HangiMarkanınAracı(); // gövdesini yazmıyoruz abstract metot olarak hepsi yazmak zoruda.
    }
}