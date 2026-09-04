using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services.Contracts;

public interface IPurchaseService
{
    Card MakePurchase();
}