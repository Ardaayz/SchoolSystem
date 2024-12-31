using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeodev
{
    public class Sinif
    {
        public int SinifId { get; set; }
        public string Adi { get; set; }
        public int Kapasite { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
