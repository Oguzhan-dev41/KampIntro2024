﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama , double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi + " " +aciklama+" " + fiyat);
        }
    }
}
