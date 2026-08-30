using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Api.Models;

public sealed class Product
{
    [Key] public Guid Id { get; set; }

    [Required] public string Title { get; set; }

    public string Description { get; set; }

    [Required] [Range(1, 100000)] public decimal Price { get; set; }

    public string Category { get; set; }
    public string SpecialTag { get; set; }
    public string Image { get; set; }
}