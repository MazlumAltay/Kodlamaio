using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // Sen burada sayı1 ile sayi2'yi eşitleyince artıkn sayi1=30 oldu.!
            sayi2 = sayi1; 
            sayi2 = 65; // Burada o yüzden ne yaparsan yap sayi1 artık 30 değerini almış.!
            // sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // sayialr1'i sayilar2'ye eşitlediğinde artık sayilar1 referans olarak sayilar2'yi tutar.!
            sayilar2[0] = 999; 
            //sayilar1[0] 999 // Burada ise sayilar1 artık sayilar2'yi tutuğun için 0. eleman 999 değerini almış oluyor.!

        }
    }
}
