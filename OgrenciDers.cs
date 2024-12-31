using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeodev
{
    public class OgrenciDers
    {
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Ders Ders { get; set; }
    }
}
