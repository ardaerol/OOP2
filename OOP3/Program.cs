using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediBaseManager konutKrediManager = new  KonutKrediManager();
            

            IKrediBaseManager tasitKredimanager = new TasitKrediManager();

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(konutKrediManager, fileLoggerService);

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() { ihtiyacKrediManager, tasitKredimanager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            




        }
    }
}
