using System;

namespace arayuzler_ornek
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkanınAracı() // bunda da başak bir şey yapmama gerek yok.
        {
            return Marka.toyota;
        }
    }
}