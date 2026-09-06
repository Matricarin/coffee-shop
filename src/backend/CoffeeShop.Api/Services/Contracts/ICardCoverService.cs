using CoffeeShop.Api.Models;
using CoffeeShop.Api.Models.Entities;

namespace CoffeeShop.Api.Services.Contracts;

public interface ICardCoverService
{
    CardCover CreateCover();
    CardCover UpdateCover(Guid id);
    void DeleteCover(Guid id);
    List<CardCover> GetCoverInfoList();
    CardCover GetCoverInfo(Guid id);
    object GetCover(Guid id);
    List<object> GetCoverList(List<Guid> id);
}