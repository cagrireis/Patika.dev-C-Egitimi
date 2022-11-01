using System;

namespace arayuzler_ornek
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.honda;
        }

        public override Renk StandartRengiNe() // bunu kendimiz çağırdık. ve değiştirdik.
        {
            return Renk.gri;
        }
    }
}