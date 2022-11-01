using System;

namespace arayuzler_ornek
{
    public class Corolla : Iotomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.beyaz;
        }
    }
}