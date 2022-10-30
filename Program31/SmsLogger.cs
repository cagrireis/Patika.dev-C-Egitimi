using System;

namespace arayuzler
{
    public class SmsLogger : Ilogger
    {
        public void writeLog() // implemente etmek demektir bu. bunu yazmak zorundayız.
        {
            Console.WriteLine("Sms olarak log yazar."); // fonksiyon seçmemize izin verir. 
        }
    }
}