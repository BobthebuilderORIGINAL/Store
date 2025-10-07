using System.ComponentModel.DataAnnotations;

namespace StoreWebApp.Data.Entities
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        public string NameProduct { get; set; } = null!;

        [Required]

        public string Picture { get; set; } = null!;

        [Required]
        public int Quantities { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
