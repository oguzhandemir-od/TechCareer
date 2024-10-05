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
        [DisplayName("Türkiye Cumhuriyeti Kimlik Numarası")]
        [MinLength(11,ErrorMessage ="TC Kimlik No 11 haneli olmalıdır!")]
        [MaxLength(11, ErrorMessage = "TC Kimlik No 11 haneli olmalıdır!")]
        public string TCKimlikNo { get; set; }
        public string BolumAd { get; set; }
        public int GirisYili {  get; set; }

        //[EmailAddress(ErrorMessage ="Lütfen eposta adresinizi doğru giriniz!")]
        //public string EPosta { get; set; }

    }
}