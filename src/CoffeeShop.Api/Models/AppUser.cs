using Microsoft.AspNetCore.Identity;

namespace CoffeeShop.Api.Models;

public class AppUser : IdentityUser
{
    public string DisplayedName { get; set; }

    //  TODO implement user model      
}