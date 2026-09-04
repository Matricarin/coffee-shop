using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services.Contracts;

public interface ICardService
{
    Card CreateCard();
    Card SetCardCover();
}