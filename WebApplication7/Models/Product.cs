using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Product
    {

        public  int ProductId { get; set; }

        [Required]
        [StringLength(60,MinimumLength =10, ErrorMessage ="ürün ismi 10-60 karakter arası olmalıdır!!!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Fiyat girmelisiniz!!!")]
        [Range(1,10000)]
        public double? Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public bool approved { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}
