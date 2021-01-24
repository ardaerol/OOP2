using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void Basvuruyap(IKrediBaseManager krediBaseManager, ILoggerService loggerService)
        {
            
            krediBaseManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
        

        
    }
}
