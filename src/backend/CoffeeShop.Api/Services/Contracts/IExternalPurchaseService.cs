using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services.Contracts;

public interface IExternalPurchaseService
{
    List<ExternalPurchase> GetPurchases(DateTime from, DateTime to);
}