using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    class DVD : IKutuphaneItem
    {
        public string Yazar { get; set; }
        public string UrunAdı { get; set; }

        public DateTime KiraTarih { get; set; }
        public string Kiralayan { get; set; }
        public int KalanGun { get ; set; }
        public string KutuphaneId { get; set; }
        public int Sayfa { get ; set ; }

        public DateTime BitisTarih()
        {
            throw new NotImplementedException();
        }

        public void KontrolIn()
        {
            throw new NotImplementedException();
        }

        public void KontrolOut(string kiralayan)
        {
            throw new NotImplementedException();
        }
    }
}
