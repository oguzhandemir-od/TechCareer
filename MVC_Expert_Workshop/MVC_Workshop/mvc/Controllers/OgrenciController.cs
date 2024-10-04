using mvc.Models;
using mvc.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()
        {
            return View(OgrenciVeri.Ogrenciler);
        }

        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Ogrenci yeniOgrenci)
        {
            OgrenciVeri.Ogrenciler.Add(yeniOgrenci);
            return RedirectToAction("Listele");
        }
    }
}