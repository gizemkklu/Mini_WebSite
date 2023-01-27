using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication7.Data;
using WebApplication7.Models;
using WebApplication7.ProductViewModels;
namespace WebApplication7.Controllers
{
    //localhost:5000/home
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            //localhost:5000/home/index
            //int saat = DateTime.Now.Hour;
            //ViewBag.Greeting = saat > 12 ? "iyi günler" : "Günaydın";
            //ViewBag.UserName = "Zeynep";
            //var products = new List<Product>()
            //{
            //    new Product { Name = "samsung", Price = 5664, Description = "en iyisi" , approved= true},
            //    new Product { Name = "samsung", Price = 5664, Description = "en iyisi" , approved= true},
            //    new Product { Name = "samsung", Price = 5664, Description = "en iyisi" , approved= false},
            //    new Product { Name = "samsung", Price = 5664, Description = "en iyisi" , approved= true},
            //    new Product { Name = "samsung", Price = 5004, Description = "en iyisi" , approved= false}
            //};
        //    var categories = new List<Category>()
        //    {
        //       new Category {Name = "Telefon" , Description = "tüm ürün listesi" },
        //       new Category{Name = "Bilgisayar" , Description = "tüm ürün listesi" },
        //       new Category { Name = "Beyaz Eşya" , Description = "tüm ürün listesi" },
        //       new Category { Name = "Mobilya" , Description = "tüm ürün listesi" }
        //};

            var ProductViewModel = new ProductViewModel()
            {
                Product = ProductRepository.Products,
                //categories = categories
            };
            return View(ProductViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
