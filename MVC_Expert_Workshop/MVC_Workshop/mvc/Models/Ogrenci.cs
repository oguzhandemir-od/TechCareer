using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Ogrenci
    {
        public int Id {  get; set; }

        [Required(ErrorMessage = "Ad Gereklidir!")]
        public string Ad {  get; set; }
        public string Soyad { get; set; }

        [Required(ErrorMessage ="TC Kimlik Numarası Gereklidir!")]
        public string TCKimlikNo { get; set; }
        public string BolumAd { get; set; }
        public int GirisYili {  get; set; }

    }
}