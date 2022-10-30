using System;

namespace arayuzler
{
    public class LogManager : Ilogger
    {
        public Ilogger _logger;
        public LogManager(Ilogger logger) // normalde interfaceler bu şekilde nesne olarak verilemezler tek başlarına anlamlı değildirler fakat biz interfaceden türemiş nesneleri constructor içine nesne olarak verebiliriz.
        {
            _logger = logger;
        }

        public void writeLog() // burası neresinin çalışacağından bihaber. Gelecek nesnenin sınıfına göre yazılacak. Onun içindeki writelog çalışacak.
        {
            _logger.writeLog();
        }
    }
}