using System;

namespace CoffeeShop.Admin.Models;

public sealed class AdminUser
{
    public string Name { get; }
    public string Email { get; }

    public AdminUser(string name, string email)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }
}