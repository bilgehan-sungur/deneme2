using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BookWay.Models.Entity;

namespace BookWay.Controllers
{
    public class LoginController : Controller
    {
        DBKITAPYOLUEntities db = new DBKITAPYOLUEntities();
        // GET: Login
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(UyeKayit u,PERSONEL p)
        {
            var bilgiler = db.UyeKayit.FirstOrDefault(x => x.KULLANICIADI == u.KULLANICIADI && x.SIFRE == u.SIFRE);
            var degerler = db.PERSONEL.FirstOrDefault(x => x.KULLANICIADI == p.KULLANICIADI && x.SIFRE == p.SIFRE);
            
            if (bilgiler != null)
            {
                Session["Kullanıcı"] = u.KULLANICIADI;
                FormsAuthentication.SetAuthCookie(bilgiler.SIFRE, false);
                 return RedirectToAction("GirisYap","Home");


            }
            else if (degerler != null)
            {
                Session["Kullanıcı"] = "Admin";
                FormsAuthentication.SetAuthCookie(degerler.SIFRE, false);
                return RedirectToAction("Index", "Uye");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya Şifre hatalı..";
                return View();
            }
        }
    }
}