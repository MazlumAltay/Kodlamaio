using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Musteri = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mazlum";
            musteri1.Soyadi = "Altay";
            musteri1.TcNo = 21124401498;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Kaya";
            musteri2.TcNo = 21124401499;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine("--------------");
            }

        }
    }
}
