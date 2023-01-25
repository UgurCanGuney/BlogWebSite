using BlogWebSite.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBlog.Controllers
{
    public class MakaleController : Controller
    {
        // GET: Makale
        MakaleRepository rep = new MakaleRepository();
        CategoryRepository catRep = new CategoryRepository();
        public ActionResult Index()
        {
            return View(rep.Listele());
        }
        public ActionResult Add()
        {
            
            return View(catRep.Listele());
        }

        [HttpPost]
        public ActionResult Add(string Baslik, string Tarih, string Yazar, string Icerik,int Kategori)
        {
            Makale m = new Makale();
            m.MakaleBaslik = Baslik;
            m.Icerik = Icerik;
            m.Tarih = Convert.ToDateTime(Tarih);
            m.Yazar = Yazar;
            m.CategoryId = Kategori;
            rep.Add(m);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            Makale m = rep.Listele().FirstOrDefault(z => z.Id == Id);
            rep.Delete(m);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            Makale m = rep.Listele().FirstOrDefault(z => z.Id == Id);

            return View(m);
        }
        
        [HttpPost]
        public ActionResult Edit(string Baslik, string Tarih, string Yazar, string Icerik, int Id,int Kategori)
        {
            Makale m = rep.Listele().FirstOrDefault(z => z.Id == Id);
            m.MakaleBaslik = Baslik;
            m.Icerik = Icerik;
            m.Tarih = Convert.ToDateTime(Tarih);
            m.Yazar = Yazar;
            m.CategoryId = Kategori;
            rep.Update(m);

            return RedirectToAction("Index");
        }
        public ActionResult Show(int Id)
        {
            Makale m = rep.Listele().FirstOrDefault(z => z.Id == Id);
            return View(m);
        }
    }
}