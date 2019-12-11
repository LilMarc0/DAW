using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProiectFinal2.Controllers
{
    public class HomeController : Controller
    {

        private ProductDBContext productDB = new ProductDBContext();

        public ActionResult Index()
        {

            Product prod = new Product
            {
                name = "Dildo"
            };
            productDB.Products.Add(prod);
            productDB.SaveChanges();
            var products = from Product in productDB.Products select Product;
            ViewBag.products = products;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}