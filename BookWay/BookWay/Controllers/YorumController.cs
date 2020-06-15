using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookWay.Models.Entity;


namespace BookWay.Controllers
{
    public class YorumController : Controller
    {

        
        DBKITAPYOLUEntities db = new DBKITAPYOLUEntities();
        public ActionResult Index()
        {
            var degerler = db.Yorum.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Contact(Yorum y)
        {

            db.Yorum.Add(y);
            db.SaveChanges();
            return View();
           /* var bilgiler = db.Yorum.FirstOrDefault(x => x.GONDEREN == y.GONDEREN);
            if (bilgiler != null)
            {
                Session["Kullanici"] = u.KULLANICIADI;
                FormsAuthentication.SetAuthCookie(bilgiler.GONDEREN, false);
                // return RedirectToAction("Index","Profil");



                return View();
            }

            else
            {
                ViewBag.Message = "Kullanıcı adı veya Şifre hatalı..";
                return View();
            }
            */
        }
        
    }
}