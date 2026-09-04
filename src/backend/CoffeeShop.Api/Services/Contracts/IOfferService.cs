using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services.Contracts;

public interface IOfferService
{
    Offer CreateBonusOffer();
    void EditBonusOffer();
}
