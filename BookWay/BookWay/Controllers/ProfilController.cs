using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookWay.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}