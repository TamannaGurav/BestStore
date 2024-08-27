using System.ComponentModel.DataAnnotations;

namespace BestStore.Models
{
    public class ProductsDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = "";

        [Required, MaxLength(100)]
        public string Brand { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Required, MaxLength(100)]
        public string Category { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        public IFormFile? ImageFile { get; set; }

        public string? ImageFileName { get; set; }
    }
}
