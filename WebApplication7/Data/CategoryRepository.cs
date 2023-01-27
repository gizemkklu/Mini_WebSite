using System.Collections.Generic;
using System.Linq;
using WebApplication7.Models;

namespace WebApplication7.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>
            {
               new Category {CategoryId=1, Name = "Telefon" , Description = "tüm ürün listesi" },
               new Category {CategoryId=2, Name = "Bilgisayar" , Description = "tüm ürün listesi" },
               new Category {CategoryId=3, Name = "Beyaz Eşya" , Description = "tüm ürün listesi" },
               new Category {CategoryId=4, Name = "teknolojik" , Description = "tüm ürün listesi" }
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }
        public static Category GetProductById(int id)
        {
            return _categories.FirstOrDefault(p => p.CategoryId == id);
        }
    }
}
