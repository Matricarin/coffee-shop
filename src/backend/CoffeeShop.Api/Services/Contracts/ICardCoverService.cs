using CoffeeShop.Api.Models;

namespace CoffeeShop.Api.Services.Contracts;

public interface ICardCoverService
{
    CardCover CreateCover();
    void DeleteCover(Guid id);
    List<CardCover> GetCoverList();
    CardCover GetCover(Guid id);
}