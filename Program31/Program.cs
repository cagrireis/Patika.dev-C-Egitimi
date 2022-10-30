using System;
using System.Collections;
using System.Collections.Generic;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface çok önemli
            // çok kullanırız.
            // pratik önemli.
            // sınıfların içermesi gereken metotların imzalarının yer aldığı ve özelliklerinin tanımlandığı bir taslak gibidir.
            // genelde I ile başlarlar I ile başlayan isimler standatlara bağlı kalınmalıdır.
            // propertylere değer ataması yapılmaz.
            // interface den kalıtım alan sınıfın sorumluluğunu bildiririr taslaktır.
            // database için ayrı loglama için ayrı gibi.
            // ilk loglama için bir tane yazacağız.
            // dosya kısmından ilk bir interface yaratmalıyız.

            FileLogger filelogger = new FileLogger();
            filelogger.writeLog();
            DatabaseLogger databaselogger = new DatabaseLogger();
            databaselogger.writeLog();
            SmsLogger smslogger = new SmsLogger();
            smslogger.writeLog();
            // çalıştı.

            // Logları düzenleyen bir yapı yazalım.

            
            LogManager logmanager = new LogManager(new FileLogger()); // biiz aslında Fileloggerdan türemiş bir nesne gönderdik. onun içindeki çalışacak.
            logmanager.writeLog();
        }
    }
}