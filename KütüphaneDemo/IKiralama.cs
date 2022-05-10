using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    public interface IKiralama : IKutuphaneItem
    {
        string Kiralayan { get; set; }
        DateTime KiraTarih { get; set; }
        int KalanGun { get; set; }

        void KontrolIn();
        void KontrolOut(string kiralayan);
        DateTime BitisTarih();
    }
}

