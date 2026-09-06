using CoffeeShop.Api.Models.Dtos.Response;

namespace CoffeeShop.Api.Services.Contracts;

public interface ICardCoverService
{
    Task<CardCoverInfoDto> CreateCover();
    Task<CardCoverInfoDto> UpdateCover();
    Task<bool> DeleteCover(Guid id);
    Task<List<CardCoverInfoDto>> GetCoverInfoList();
    Task<CardCoverInfoDto> GetCoverInfo(Guid id);

    // BUG: временно возвращаем строки вместо файлов
    Task<string> GetCover(Guid id);
    Task<List<string>> GetCoverList(List<Guid> id);
}