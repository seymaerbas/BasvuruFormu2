using BasvuruFormu2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasvuruFormu2.Controllers
{
    public class BasvuruController : Controller
    {
        // GET: Basvuru
        Context c = new Context();
       

        [HttpGet]
        public ActionResult Index(int? id)
        {

            ViewBag.deger = id;

            ViewBag.GeziListesi = c.Geziler.Where(g => g.Status).ToList();
            return PartialView();
        }
        protected override void Dispose(bool disposing)
        {
            c.Dispose();
        }

        [HttpPost]
        public ActionResult Index(Form b)
        {
            b.UniqueTC = b.TC;

            // Aynı TC kimlik numarasıyla daha önce başvuru yapılmış mı kontrol et
            var existingForm = c.Formlar.FirstOrDefault(f => f.TC == b.TC);
            if (existingForm != null)
            {
                TempData["NotificationMessage"] = "Bu TC kimlik numarasıyla zaten başvuru yapılmıştır!";
                TempData["NotificationType"] = "error";
                return RedirectToAction("Index");
            }
            // Yaş kontrolü
            var today = DateTimeOffset.Now;
            var age = today.Year - b.DogumTarihi.Year;
            if (today < b.DogumTarihi.AddYears(age))
            {
                age--;
            }

            if (age > 30)
            {
                ModelState.AddModelError("DogumTarihi", "Başvuru yapmak için 30 yaşından küçük olmanız gerekmektedir.");
            }

            if (ModelState.IsValid)
            {
                c.Formlar.Add(b);
                c.SaveChanges();
                TempData["NotificationMessage"] = "Başvurunuz başarıyla alındı!";
                TempData["NotificationType"] = "success";

                return RedirectToAction("Index");
            }

            // Gezi verilerini ViewBag ile view'e gönderme
            ViewBag.GeziListesi = c.Geziler.ToList();

            return View(b);
        }
    }
}