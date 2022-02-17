using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos{
    public record DeleteItemDto{
        [Required]
       public Guid id { get; init;}
    }
}