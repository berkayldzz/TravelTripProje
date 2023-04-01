using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap

        Context c = new Context();

        
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Admin a)
        {
            // Kullanıcı adı ve şifrenin doğru olup olmadığını kontrol eden linq sorgusu

            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == a.Kullanici && x.Sifre == a.Sifre);

            if(bilgiler!=null) // Eğer bilgiler boş değilse yani doğru giriş yapılıyorsa,yukarıdaki şartlar sağlanıyorsa aşağıdaki işlem gerçekleşicek.
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici,false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }


    }
}