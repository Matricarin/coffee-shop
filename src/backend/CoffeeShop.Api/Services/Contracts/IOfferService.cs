using CoffeeShop.Api.Models;
using CoffeeShop.Api.Models.Entities;

namespace CoffeeShop.Api.Services.Contracts;

public interface IOfferService
{
    Offer CreateBonusOffer();
    void EditBonusOffer();
}
