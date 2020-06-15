using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BookWay.Models.Entity;

namespace BookWay.Controllers
{
    public class HomeController : Controller
    {

        DBKITAPYOLUEntities db = new DBKITAPYOLUEntities();
        

        public ActionResult en_cok_cocuk()
        {
            return View();
        }
        public ActionResult cok_satan_aylik()
        {
            return View();
        }
        public ActionResult en_cok_edebiyat()
        {
            return View();
        }
        public ActionResult yeni_cikan_cocuk()
        {
            return View();
        }
        public ActionResult yeni_cikan_sinav()
        {
            return View();
        }
        public ActionResult yeni_cikan_bilgisayar()
        {
            return View();
        }
        public ActionResult tum_kitaplar()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        }
        public ActionResult GirisYap()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(UyeKayit u)
        {
            

            var bilgiler = db.UyeKayit.FirstOrDefault(x => x.KULLANICIADI == u.KULLANICIADI && x.SIFRE == u.SIFRE);
            Session["bilgiler"] = bilgiler;
          



            if (bilgiler != null)
            {
                Session["Kullanici"] = u.KULLANICIADI;
                FormsAuthentication.SetAuthCookie(bilgiler.SIFRE, false);
                // return RedirectToAction("Index","Profil");
               
                
                
                return View();
            }

            else 
            {
                ViewBag.Message = "Kullanıcı adı veya Şifre hatalı..";
                return View();
            }


            
        }
        
        



    }
}