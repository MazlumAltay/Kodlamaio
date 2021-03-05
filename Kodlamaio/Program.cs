using System;

namespace Kodlamaio
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";

            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Degişmedi Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine(" Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(KategoriEtiketi);
        }
    }
}
