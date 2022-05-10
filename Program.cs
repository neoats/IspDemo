using KütüphaneDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1-2 tane daha kombinasyon yap
namespace IspDemo
{
    class Program
    {
        static void Main(string[] args)
        {   //solid mantığı
            //ikiralanan dvd sayesinde hem kiralama hem dvd hem kütüphaneid ye ulaşabiliyoruz
            //propları interface kombinasyonlarıyla ayırdık
            //tek bir interface te toplanında hepsini birden çağırıyor
            IKiralananDVD dvd = new DVD();
            DVD ad = new DVD();
             
        }
    }
}
