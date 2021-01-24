using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "1212131331";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1231313313";


        }
    }
}
