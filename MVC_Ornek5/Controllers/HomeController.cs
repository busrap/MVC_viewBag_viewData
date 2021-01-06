using MVC_Ornek5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Ornek5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Kategori> kategoriler = new List<Kategori>
            {
                new Kategori { Id = 1, KategoriAdi = "Beverages", Aciklama = "Soft drinks, coffees, teas, beers, and ales"},
                new Kategori { Id = 2, KategoriAdi = "Condiments", Aciklama = "Sweet and savory sauces, relishes, spreads, and seasonings"},
                new Kategori { Id = 3, KategoriAdi = "Confections", Aciklama = "Desserts, candies, and sweet breads"},
                new Kategori { Id = 4, KategoriAdi = "Dairy Products", Aciklama = "Cheeses"},
                new Kategori { Id = 5, KategoriAdi = "Grains/Cereals", Aciklama = "Breads, crackers, pasta, and cereal"}
            };

            ViewData["KategoriListesi"] = kategoriler;
            ViewBag.KategoriListesi = kategoriler;
            TempData["KategoriListesi"] = kategoriler;

            return View();
        }

        public ActionResult Category()
        {
            return View();
        }
    }
}