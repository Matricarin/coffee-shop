using CoffeeShop.Admin.ViewModels;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.Services;

public interface IUiNavigationService
{
    Task NavigateToAsync<T>() where T : ViewModel;
}

public sealed class UiNavigationService : IUiNavigationService
{
    public Task NavigateToAsync<T>() where T : ViewModel
    {
        throw new NotImplementedException();
    }
}