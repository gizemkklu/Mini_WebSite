using System.Collections.Generic;
using System.Linq;
using WebApplication7.Models;

namespace WebApplication7.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;
        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, Name = "samsung", Price = 5664, Description = "en telefon" , approved= true, ImageUrl="indir.jpg", CategoryId=1},
                new Product { ProductId = 2, Name = "bosh", Price = 5664, Description = "en çamaşır makinesi" , approved= true, ImageUrl="camasirmak.jpg", CategoryId=3},
                new Product { ProductId = 3, Name = "canon", Price = 5664, Description = "en fotoğraf makinesi" , approved= false, ImageUrl="ftmakine.jpg", CategoryId=4},
                new Product { ProductId = 4, Name = "apple", Price = 5664, Description = "en tablet" , approved= true, ImageUrl="tablet.jpg", CategoryId=4},
                new Product { ProductId = 5, Name = "arçelik", Price = 5004, Description = "en ütü" , approved= false, ImageUrl="utu.jpg", CategoryId=3},
                new Product { ProductId = 6, Name = "samsung", Price = 5664, Description = "en telefon" , approved= true, ImageUrl="indir.jpg", CategoryId=1},
                new Product { ProductId = 7, Name = "bosh", Price = 5664, Description = "en çamaşır makinesi" , approved= true, ImageUrl="camasirmak.jpg", CategoryId=3},
                new Product { ProductId = 8, Name = "canon", Price = 5664, Description = "en fotoğraf makinesi" , approved= false, ImageUrl="ftmakine.jpg", CategoryId=4},
                new Product { ProductId = 9, Name = "apple", Price = 5664, Description = "en tablet" , approved= true, ImageUrl="tablet.jpg", CategoryId=4},
                new Product { ProductId = 10, Name = "arçelik", Price = 5004, Description = "en ütü" , approved= false, ImageUrl="utu.jpg", CategoryId=3},
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
        public static void EditProduct(Product product)
        {
            foreach(var p in _products)
            {
                if(p.ProductId == product.ProductId)
                {                
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.Description = product.Description;
                    p.ImageUrl = product.ImageUrl;
                    p.approved = product.approved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if(product != null)
            {
                _products.Remove(product);
            }    
        }
    }
}
