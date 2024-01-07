using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? 30 
            // sayısal veri tipleri int,dobule,float,decimal, bool değer tiplerdir.
            // array,class , interface referans tiplerdir.
            //Bellekte stack ve heap adında 2 alan vardır.Değer tipler stackte gerçekleşir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0} ? 999

            
        }
    }
}