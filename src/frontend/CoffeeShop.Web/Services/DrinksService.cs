using CoffeeShop.Web.Models;

namespace CoffeeShop.Web.Services;

public sealed class DrinksService
{
    public async Task<List<DrinkItem>> GetDrinksAsync()
    {
        await Task.Delay(300);

        return
        [
            new DrinkItem
            (
                Guid.NewGuid(),
                "Espresso",
                "Black, tasty and hot",
                1.25m,
                "/img/espresso.png"
            ),
            new DrinkItem
            (
                Guid.NewGuid(),
                "Cappuccino",
                "Milky, fancy and soft",
                2.00m,
                "/img/cappuccino.png"
            ),
            new DrinkItem
            (
                Guid.NewGuid(),
                "Flat-White",
                "Milky, fancy and strong",
                1.80m,
                "/img/flat-white.png"
            ),
            new DrinkItem
            (
                Guid.NewGuid(),
                "Latte",
                "Milky, chilly and creamy",
                2.50m,
                "/img/latte.png"
            ),
        ];
    }
}