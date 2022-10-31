using System;

namespace arayuzler_ornek
{
    public class Civic : Iotomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.gri;
        }
    }
}