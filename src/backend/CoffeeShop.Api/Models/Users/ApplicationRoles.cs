namespace CoffeeShop.Api.Models.Users;

public static class ApplicationRoles
{
    public const string Administrator = "administrator";
    public const string Client = "client";
    public static readonly string[] AvailableRoles = [Administrator, Client];
}