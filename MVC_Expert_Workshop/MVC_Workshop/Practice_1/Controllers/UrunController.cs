using Practice_1.Models;
using Practice_1.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_1.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Listele()
        {
            return View(UrunVeri.Urunler);
        }

        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Urun yeniUrun)
        {
            return RedirectToAction("Listele");
        }
    }
}