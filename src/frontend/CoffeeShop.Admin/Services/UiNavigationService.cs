using CoffeeShop.Admin.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.Services;

public interface IUiNavigationService
{
    Task NavigateToAsync<T>() where T : ViewModel;
}

public sealed class UiNavigationService : IUiNavigationService
{
    private readonly IServiceProvider _serviceProvider;
    private MainWindowViewModel _mainWindowViewModel;

    public Task NavigateToAsync<T>() where T : ViewModel
    {
        if (_mainWindowViewModel is null)
        {
            return Task.CompletedTask;
        }

        _mainWindowViewModel.CurrentPage = _serviceProvider.GetRequiredService<T>();
        return Task.CompletedTask;
    }

    public UiNavigationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
    }

    public void SetMainWindowViewModel(MainWindowViewModel viewModel)
    {
        _mainWindowViewModel = viewModel;
    }
}