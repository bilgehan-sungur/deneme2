﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookWay.Models.Entity;

namespace BookWay.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        DBKITAPYOLUEntities db = new DBKITAPYOLUEntities();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = db.UyeKayit.ToList();
            return View(degerler);
        }
       

        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeEkle(UyeKayit u)
        {
            db.UyeKayit.Add(u);
            db.SaveChanges();
            return View();

        }
        public ActionResult UyeSil(int id)
        {
            var uye = db.UyeKayit.Find(id);
            db.UyeKayit.Remove(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UyeGetir(int id)
        {
            var uye = db.UyeKayit.Find(id);
            return View("UyeGetir",uye);
        }
        public ActionResult UyeGuncelle(UyeKayit u)
        {
            var uye = db.UyeKayit.Find(u.ID);
            uye.KULLANICIADI = u.KULLANICIADI;
            uye.AD = u.AD;
            uye.SOYAD = u.SOYAD;
            uye.EMAIL = u.EMAIL;
            uye.SIFRE = u.SIFRE;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}