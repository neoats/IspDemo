using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneDemo
{
    public interface IDVD :IKutuphaneItem
    {
       List<string> Actors { get; set; }
        int CalmaSuresi { get; set; }
      
    }
}

