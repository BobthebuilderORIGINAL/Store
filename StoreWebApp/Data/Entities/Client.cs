using System.ComponentModel.DataAnnotations;

namespace StoreWebApp.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string EGN { get; set; } = null!;
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        public string Town { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    }
}
