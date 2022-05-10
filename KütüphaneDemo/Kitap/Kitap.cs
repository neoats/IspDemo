using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    class Kitap : IKiralananKitap    
    {//kiralanan kitap ,kitap ve itemden inherit
        public string Yazar { get; set; }
        public DateTime KiraTarih { get; set; }
        public string Kiralayan { get; set; }
        public int KalanGun { get; set; } = 14;
        public string KutuphaneId { get; set; }
        public int Sayfa { get; set; }
        public string UrunAdı { get ; set; }

        public DateTime BitisTarih( )
        {
            throw new NotImplementedException();
        
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
