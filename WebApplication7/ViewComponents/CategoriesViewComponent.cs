using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //var categories = new List<Category>()
            //{
            //   new Category {Name = "Telefon" , Description = "tüm ürün listesi" },
            //   new Category{Name = "Bilgisayar" , Description = "tüm ürün listesi" },
            //   new Category { Name = "Beyaz Eşya" , Description = "tüm ürün listesi" },
            //   new Category { Name = "Mobilya" , Description = "tüm ürün listesi" }
            //};

               ViewBag.SelectedCategory = RouteData?.Values["id"];
            
                  
            return View(CategoryRepository.Categories);
        }
    }
}
