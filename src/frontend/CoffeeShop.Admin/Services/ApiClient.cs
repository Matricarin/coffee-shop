using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.Services;

public sealed class ApiClient
{
    private readonly HttpClient _http;

    public ApiClient(IConfiguration config)
    {
        _http = new HttpClient();
        _http.BaseAddress = new Uri(config["BaseAddress"] ?? "localhost:8080");
    }

    public async Task LoginAsync()
    {
    }

    public async Task RegisterAsync()
    {
    }

    public async Task LogoutAsync()
    {
    }
}