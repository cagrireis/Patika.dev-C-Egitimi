using System;

namespace arayuzler_ornek
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkanınAracı() // sadece tek bir metot ile kurtuldum değişmesi oluşturulması zorunlu olan bu.
        {
            return Marka.ford;
        }
    }
}