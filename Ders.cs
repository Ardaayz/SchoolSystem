using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeodev
{
    public class Ders
    {
        public int DersId { get; set; }
        public string Baslik { get; set; }
        public virtual ICollection<OgrenciDers> OgrenciDersleri { get; set; }
    }
}
