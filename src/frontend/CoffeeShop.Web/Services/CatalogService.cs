namespace CoffeeShop.Web.Services;

public sealed class CatalogService
{
    private readonly HttpClient _httpClient;

    public CatalogService(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public Task<object> GetCatalogItems()
    {
        throw new NotImplementedException();
    }
}