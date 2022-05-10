using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
   public interface IKutuphaneItem
    {
        string KutuphaneId { get; set; }
        string UrunAdı { get; set; }
        //string  Yazar { get; set; }
        //int Sayfa { get; set; }
        //string Kiralayan { get; set; }
        //DateTime KiraTarih { get; set; }
   
        //int KalanGun { get; set; }
    
        //void KontrolIn();
        //void KontrolOut(string kiralayan);
        //DateTime BitisTarih();
    }
}
