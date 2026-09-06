using CoffeeShop.Api.Models;
using CoffeeShop.Api.Models.Entities;

namespace CoffeeShop.Api.Services.Contracts;

public interface IPurchaseService
{
    Purchase MakePurchase(Card card);
}