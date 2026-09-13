using System;
using System.Net.Http;
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
    private readonly HttpClient _api;

    public Task RegisterAsync(string name, string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task LogoutAsync()
    {
        throw new NotImplementedException();
    }

    public AuthenticationService(HttpClient api)
    {
        _api = api ?? throw new ArgumentNullException(nameof(api));
    }
}