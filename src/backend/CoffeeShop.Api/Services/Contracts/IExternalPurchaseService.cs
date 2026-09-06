using CoffeeShop.Api.Models;
using CoffeeShop.Api.Models.Dtos.Response;

namespace CoffeeShop.Api.Services.Contracts;

public interface IExternalPurchaseService
{
    List<ExternalPaymentSystemResponse> GetPurchases(DateTime from, DateTime to);
}