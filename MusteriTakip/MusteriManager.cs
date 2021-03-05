using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + musteri.Adi);

        }

        public void Ekle2(string musteriAdi, string musteriSoyadi, Double TcNo)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + musteriAdi);
        }
    }
}
