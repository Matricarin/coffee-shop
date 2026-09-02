using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Api.Models;

public sealed class ApplicationUser : IdentityUser<Guid>
{
    [Required] public string Name { get; init; } = null!;
    [Required] public DateTime CreatedDate { get; set; } = DateTime.Now;   
}