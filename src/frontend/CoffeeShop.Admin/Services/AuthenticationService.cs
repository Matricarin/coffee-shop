using System.Threading.Tasks;

namespace CoffeeShop.Admin.Services;

public interface IAuthenticationService
{
    Task RegisterAsync(string name, string email, string password);
    Task LoginAsync(string email, string password);
    Task LogoutAsync();
}

public sealed class AuthenticationService : IAuthenticationService
{
    public Task RegisterAsync(string name, string email, string password)
    {
        throw new System.NotImplementedException();
    }

    public Task LoginAsync(string email, string password)
    {
        throw new System.NotImplementedException();
    }

    public Task LogoutAsync()
    {
        throw new System.NotImplementedException();
    }
}