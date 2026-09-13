using CoffeeShop.Admin.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.Services;

public interface IAuthenticationService
{
    Task<bool> RegisterAsync(string name, string email, string password);
    Task<bool> LoginAsync(string email, string password);
    Task<bool> LogoutAsync();
}

public sealed class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _api;

    public async Task<bool> RegisterAsync(string name, string email, string password)
    {
        var data = new RegisterDto(name, email, password);

        var json = JsonSerializer.Serialize(data);

        HttpResponseMessage result = await _api.PostAsJsonAsync("api/admin-auth/register", json);

        return result.IsSuccessStatusCode;
    }

    public async Task<bool> LoginAsync(string email, string password)
    {
        var data = new LoginDto(email, password);

        var json = JsonSerializer.Serialize(data);

        var result = await _api.PostAsJsonAsync("api/admin-auth/login", json);

        return result.IsSuccessStatusCode;
    }

    public Task<bool> LogoutAsync()
    {
        throw new NotImplementedException();
    }

    public AuthenticationService(HttpClient api)
    {
        _api = api ?? throw new ArgumentNullException(nameof(api));
    }
}