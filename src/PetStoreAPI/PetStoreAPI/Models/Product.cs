using System.ComponentModel.DataAnnotations;

namespace PetStoreAPI.Models
{
    public class Product
    {
        [Key]
        public long Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
