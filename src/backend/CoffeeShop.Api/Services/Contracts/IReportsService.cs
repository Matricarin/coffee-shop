using CoffeeShop.Api.Models.Reports;

namespace CoffeeShop.Api.Services.Contracts;

public interface IReportsService
{
    UsersActivityReport GenerateUsersActivity();

    CoversRatingReport GenerateCoversRating();

    CardsPurchasesReport GenerateCardsPurchases();
}