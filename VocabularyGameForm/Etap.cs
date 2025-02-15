﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyGameForm
{
    public class Etap
    {
         int _id;
         string _Soru;
         string _Cevap;
        int _harfSayisi;
        private bool[] acilan;
        private int _alinanHarf;
        public Etap(int id, string soru, string cevap)
        {
            _id = id;
            _Soru = soru;
            _Cevap = cevap;
            _harfSayisi = cevap.Length;
            _alinanHarf = 0;
            Acilan = new bool[_harfSayisi];
            for (int i = 0; i < _harfSayisi; i++)
            {
                Acilan[i] = false;
            }
        }
        public int alinanHarf()
        {
            return _alinanHarf;
        }
        public void harfAl()
        {
            int index;
            Random rnd = new Random();
            do
            {
                index = rnd.Next(0, _harfSayisi);
            } while (Acilan[index]);
            Acilan[index] = true;
            _alinanHarf++;
        }
        public int skorDegeri()
        {
            return _harfSayisi * 100;
        }
        public int acilmayanHarfSayisi()
        {
            int adet = 0;
            foreach (bool item in Acilan)
            {
                if (!item)
                {
                    adet++;
                }
            }
            return adet;
        }
        public bool acildiMi()
        {
            foreach (bool item in Acilan)
            {
                if (!item)
                {
                    return false;
                }
            }
            return true;
        }
        public int HarfSayisi
        {
            get
            {
                return _harfSayisi;
            }
            set
            {
                _harfSayisi = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Soru
        {
            get
            {
                return _Soru;
            }

            set
            {
                _Soru = value;
            }
        }
        public string Cevap
        {
            get
            {
                return _Cevap;
            }

            set
            {
                _Cevap = value;
            }
        }

        public bool[] Acilan { get => acilan; set => acilan = value; }
    }
}
