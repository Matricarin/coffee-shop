using CoffeeShop.Admin.Models;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.Services;

public interface IAuthenticationService
{
    Task RegisterAsync(string name, string email, string password);
    Task<AdminUser> LoginAsync(string email, string password);
    Task LogoutAsync();
}

public sealed class AuthenticationService
{
    
}