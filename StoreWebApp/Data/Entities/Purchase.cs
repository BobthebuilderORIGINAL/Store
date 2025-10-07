using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreWebApp.Data.Entities
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int Quntities { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal Discount { get; set; }
        [Required]
        public DateTime DateSale { get; set; }
    }
}
