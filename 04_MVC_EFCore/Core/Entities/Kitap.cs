using System.ComponentModel.DataAnnotations;

namespace _04_MVC_EFCore.Core.Entities
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }
}
