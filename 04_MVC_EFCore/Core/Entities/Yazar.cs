using System.ComponentModel.DataAnnotations;

namespace _04_MVC_EFCore.Core.Entities
{
    public class Yazar
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int KitapSayisi { get; set; }
    }
}
