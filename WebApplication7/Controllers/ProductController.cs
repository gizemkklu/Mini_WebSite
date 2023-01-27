using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using WebApplication7.Data;
using WebApplication7.Models;
using WebApplication7.ProductViewModels;

namespace WebApplication7.Controllers
{
    //localhost:5000/product
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int? id, string p)
        {
            
            //localhost:5000/product/list
            //var products = new List<Product>()
            //{
            //    new Product { ProductId = 1, Name = "samsung", Price = 5664, Description = "en iyisi" , approved= true, ImageUrl="~/images/indir.jpg"},
            //    new Product { ProductId = 2, Name = "samsung", Price = 5664, Description = "en iyisi" , approved= true, ImageUrl="~/images/indir.jpg"},
            //    new Product { ProductId = 3, Name = "samsung", Price = 5664, Description = "en iyisi" , approved= false, ImageUrl="~/images/indir.jpg"},
            //    new Product { ProductId = 4, Name = "samsung", Price = 5664, Description = "en iyisi" , approved= true, ImageUrl="~/images/indir.jpg"},
            //    new Product { ProductId = 5, Name = "samsung", Price = 5004, Description = "en iyisi" , approved= false, ImageUrl="~/images/indir.jpg"}
            //};

            // /product/list => tüm ürünleri getir (sayfala)
            // /product/list/2 => 2 numaralı kategorye ait ürünleri getir
            var products = ProductRepository.Products;
            if (!string.IsNullOrEmpty(p))
            {
                products = products.Where(i=>i.Name.ToLower().Contains(p.ToLower()) || i.Description.ToLower().Contains(p.ToLower())).ToList();
            }
            if (id != null)
            {
                products = products.Where(p=>p.CategoryId == id).ToList();
            }
            var ProductViewModel = new ProductViewModel()
            {
                Product = products
                //categories = categories
            };
            return View(ProductViewModel);
        }

        public IActionResult Details(int id)
        {
            //localhost:5000/product/details
            
            return View(ProductRepository.GetProductById(id));
        }
        [HttpGet] //varsayılan 
        public IActionResult Create()
        {

            ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);
                return RedirectToAction("list");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(p);
        }

        [HttpGet] //varsayılan 
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            ProductRepository.EditProduct(p);
            return RedirectToAction("list"); //işlem bittikten sonra kullanıcıyı farklı bir etki sayfasına gönderdik

        }

        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");
        }
    }
}   
