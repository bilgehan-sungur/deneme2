using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookWay.Models.Entity;
using System.Web.Security;

namespace BookWay.Controllers
{
    public class KitaplarController : Controller
    {
        // GET: Kitaplar
        DBKITAPYOLUEntities db = new DBKITAPYOLUEntities();
        
        public ActionResult Ilber_Ortayli()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        

        public ActionResult Incir_Kuslari(Yorum y)
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        public ActionResult Yabanci()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        public ActionResult Stephen()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        public ActionResult Korluk()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        public ActionResult Seker_Portakali()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        public ActionResult Simyaci()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
        public ActionResult Bilinmeyen_Bir_Kadin()
        {
            var yorum = db.Yorum.ToList();
            return View(yorum);
        }
    }
}