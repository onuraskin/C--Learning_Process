using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class araba: ArabaDetay
    {
        public string renk;
        public int hız;
        public double motorgüc;
        public char durum;
        public int fiyat;
        private int yil;
        private string Marka;
        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
        public string Markasi
        {
            get { return Marka; }
            set {  Marka = value.ToUpper(); }
        }

    }
}