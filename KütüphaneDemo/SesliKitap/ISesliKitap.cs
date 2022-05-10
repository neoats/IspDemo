using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    public interface ISesliKitap : IKutuphaneItem
    {
        int CalmaSuresi { get; set; }
    }
}
