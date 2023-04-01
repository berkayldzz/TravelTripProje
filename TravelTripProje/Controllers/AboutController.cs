using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar; // !!


namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        // Context üzerinden nesne türetiyorum ki sınıflarımı kullanabileyim

        Context c = new Context(); 

        // c isimli nesne yardımıyla contexte bağlı bulunan sınıflarıma( Hakkimizda sınıfına) eriştim.
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList(); 
            return View(degerler);
        }
    }
}