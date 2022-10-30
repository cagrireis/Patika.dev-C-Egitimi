using System;

namespace arayuzler
{
    public class FileLogger : Ilogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}