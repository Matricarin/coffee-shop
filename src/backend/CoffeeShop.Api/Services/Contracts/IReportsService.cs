using CoffeeShop.Api.Models.Reports;

namespace CoffeeShop.Api.Services.Contracts;

public interface IReportsService
{
    Task<UsersActivityReport> GenerateUsersActivityAsync(DateOnly from, DateOnly to);
    Task<CoversRatingReport> GenerateCoversRatingAsync(DateOnly from, DateOnly to);
    Task<RedemptionRateReport> GenerateRedemptionRateAsync(DateOnly from, DateOnly to);
    Task<RetentionRateReport> GenerateRetentionRateAsync(DateOnly from, DateOnly to);
}