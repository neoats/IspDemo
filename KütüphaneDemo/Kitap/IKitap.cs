using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    public interface IKitap : IKutuphaneItem
    {
        string Yazar { get; set; }
        int Sayfa { get; set; }

    }
}
