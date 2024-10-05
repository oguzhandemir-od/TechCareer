using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice_1.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunMagazasi { get; set; }
        public string UrunOzellikleri { get; set; }
        public int UrunFiyati { get; set; }
        public int UrunKargoSuresi { get; set; }

    }
}