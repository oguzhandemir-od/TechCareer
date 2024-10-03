using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Ogrenci
    {
        public int Id {  get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public string TCKimlikNo { get; set; }
        public string BolumAd { get; set; }
        public int GirisYili {  get; set; }

    }
}