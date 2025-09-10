using System.ComponentModel.DataAnnotations;
using MVC_App_1.Enums;

namespace MVC_App_1.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        [StringLength(10, ErrorMessage = "Ürün adı 10 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı zorunludur.")]
        [Range(10, 999999, ErrorMessage = "Ürün fiyatı 10 TL'den az, 999999'den fazla olamaz.")]
        public decimal Price { get; set; }

        [StringLength(100, ErrorMessage = "Ürün açıklaması 100 karakterden fazla olamaz.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Ürün kategorisi zorunludur.")]
        public CategoryEnum Category { get; set; }
    }
}