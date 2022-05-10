using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    class ReferansKitap: IKitap
    {
        public string KutuphaneId { get; set; }
        public string UrunAdı { get; set; }

        public string Yazar { get; set; }
 
        public int Sayfa { get; set; }

    }
}
