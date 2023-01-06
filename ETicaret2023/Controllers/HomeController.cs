using ETicaret2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret2023.Controllers
{
    public class HomeController : Controller
    {
         private ETicaretEntities db = new ETicaretEntities();
        public ActionResult Index()
        {
           ViewBag.Kategoriler = db.Kategoriler.ToList();
           ViewBag.urunler = db.Urunler.ToList();
           return View();
        }

        public ActionResult Kategori(int id)
        {
            ViewBag.Kategoriler = db.Kategoriler.ToList();
            ViewBag.kategori=db.Kategoriler.Find(id);
            return View(db.Urunler.Where(x=>x.KategoriID==id).ToList());
        }

        public ActionResult Urun(int id)
        {
            ViewBag.Kategoriler = db.Kategoriler.ToList();
     
            return View(db.Urunler.Find(id));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}