using System;

namespace arayuzler_ornek
{
    public class focus : Iotomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.ford;
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