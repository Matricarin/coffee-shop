using CoffeeShop.Api.Models.Users;

namespace CoffeeShop.Api.Services.Contracts;

public interface IAdministratorsService
{
    Administrator Register();
    void Login();
}