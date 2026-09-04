using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services.Contracts;

public interface ICardHolderService
{
    List<Card> GetClientCards();
    List<Card> GetActiveClientCard();
}