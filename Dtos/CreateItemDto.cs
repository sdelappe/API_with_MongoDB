using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateItemDto
    {
        // [Required] is a Data Annotation, which in this case means Name and Price have to be provided
        // when creating an item
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}