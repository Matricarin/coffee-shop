using CoffeeShop.Admin.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Admin.ViewModels;

public partial class MainWindowViewModel : ViewModel
{
    private readonly IUiNavigationService _navigationService;
    [ObservableProperty] private ViewModel currentPage;

    public MainWindowViewModel(IUiNavigationService navigationService)
    {
        _navigationService = navigationService;
        ((UiNavigationService)_navigationService).SetMainWindowViewModel(this);
        _navigationService.NavigateToAsync<LoginViewModel>();
    }

    public MainWindowViewModel() : this(null!)
    {
    }
}