using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    interface IKutuphaneItem
    {
        string KutuphaneId { get; set; }
        string UrunAdı { get; set; }
        string  Yazar { get; set; }
        DateTime KiraTarih { get; set; }
        string Kiralayan { get; set; }
        int KalanGun { get; set; }
        int Sayfa { get; set; }
        void KontrolIn();
        void KontrolOut(string kiralayan);
        DateTime BitisTarih();
    }
}
