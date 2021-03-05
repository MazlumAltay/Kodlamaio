using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type-safe -- Tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");

            }

            Console.WriteLine("------------------Methods----------------");
            //İnstance - Örnek
            //Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);  // Methodu böyle çağırıyoruz.  
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 10);


        }
    }
}

// Dont repeat yourself! - DRY -> Kendini Tekrar Etme!
// Clean Cod - Temiz kod yazımı!. 
// Best Practice
// Tekrar tekrar kullanılacak durumlarda oluşturulan metotlar ile temiz cod blokları ile hızlı işlemler gerçekleştirilir.!
// C# - Java'da Tüm olaylar Classların içerisinde olur.
