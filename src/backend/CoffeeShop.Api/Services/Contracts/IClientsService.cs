using CoffeeShop.Api.Models.Users;

namespace CoffeeShop.Api.Services.Contracts;

public interface IClientsService
{
    Client Register();
    void Login();
    void Confirm();
}