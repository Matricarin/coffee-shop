using CoffeeShop.Web.Models;

namespace CoffeeShop.Web.Services;

public sealed class CatalogService
{
    public async Task<List<CatalogItem>> GetCatalogItemsAsync()
    {
        await Task.Delay(300);

        return
        [
            new CatalogItem
            (
                Guid.NewGuid(),
                "Espresso",
                "Black, tasty and hot",
                1.25m,
                "/images/espresso.jpg"
            ),
            new CatalogItem
            (
                Guid.NewGuid(),
                "Cappuccino",
                "Milky, fancy and soft",
                2.00m,
                "/images/cappuccino.jpg"
            ),
            new CatalogItem
            (
                Guid.NewGuid(),
                "Flat White",
                "Milky, fancy and strong",
                1.80m,
                "/images/flat-white.jpg"
            ),
            new CatalogItem
            (
                Guid.NewGuid(),
                "Latte",
                "Milky, chilly and creamy",
                2.50m,
                "/images/latte.jpg"
            ),
        ];
    }
}