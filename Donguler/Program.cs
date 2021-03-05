using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme kampı", "Programlamya başlangıç için temel kurs", "java" };

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(kurslar[i]); 
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
