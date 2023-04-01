using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Tokenizer;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        Context c = new Context();

        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1=c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();    // Son 3 blogu listele anlamında kullandık


            return View(by);
        }
        // Sınıfımdan bir nesne türetmem gerekiyor

        public ActionResult BLogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1= c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);

        }

        // Yorum Yapma 

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;  // BlogIdyi de yorum kısmına taşımak istiyoruz
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }

    }
}