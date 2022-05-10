﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    class SesliKitap : IKiralananSesliKitap   
    {
        public string Yazar { get; set; }
        public string UrunAdı { get; set; }

        public DateTime KiraTarih { get; set; }
        public string Kiralayan { get; set; }
        public int KalanGun { get; set; } = 14;
        public string KutuphaneId { get; set; }

        public int CalmaSuresi { get; set; }

        public DateTime BitisTarih()
        {
            return KiraTarih.AddDays(KalanGun);
        }

        public void KontrolIn()
        {
            Kiralayan = "";
        }

        public void KontrolOut(string kiralayan)
        {
            Kiralayan = kiralayan;
            KiraTarih = DateTime.Now;
        }
    }
}
