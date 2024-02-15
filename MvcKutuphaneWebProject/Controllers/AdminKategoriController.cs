using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphaneWebProject.Models.Entity;

namespace MvcKutuphaneWebProject.Controllers
{
    public class AdminKategoriController : Controller
    {
        // GET: AdminKategori
        MvcKutuphaneDbEntities db = new MvcKutuphaneDbEntities();
        public ActionResult Index()
        {
            var kategori = db.TblKategori.ToList();
            return View(kategori);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(TblKategori k)
        {
            db.TblKategori.Add(k);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriAktifYap(int id)
        {
            var kategori = db.TblKategori.Find(id);
            kategori.KategoriDurum = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriPasifYap(int id)
        {
            var kategori = db.TblKategori.Find(id);
            kategori.KategoriDurum = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = db.TblKategori.Find(id);
            return View("KategoriGetir", kategori);
        }

        public ActionResult KategoriGuncelle(TblKategori k)
        {
            var kategori = db.TblKategori.Find(k.KategoriID);
            kategori.KategoriAd = k.KategoriAd;
            kategori.KategoriDetay = k.KategoriDetay;
            kategori.KategoriDurum = k.KategoriDurum;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}