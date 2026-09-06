using CoffeeShop.Api.Models;
using CoffeeShop.Api.Models.Entities;

namespace CoffeeShop.Api.Services.Contracts;

public interface ICardService
{
    Card CreateCard();
    Card SetCardCover();
    List<Card> GetClientCards();
    List<Card> GetActiveClientCard();
}