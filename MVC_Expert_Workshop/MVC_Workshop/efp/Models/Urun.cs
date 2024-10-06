using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace efp.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad {  get; set; }
        public double Fiyat { get; set; }
        public int StokSayisi { get; set; }

    }
}