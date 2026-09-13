using CoffeeShop.Admin.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.ViewModels;

public partial class LoginViewModel : ViewModel
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUiNavigationService _navigationService;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
    private string email = string.Empty;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
    private string password = string.Empty;

    public LoginViewModel
    (
        IAuthenticationService authenticationService,
        IUiNavigationService navigationService
    )
    {
        _authenticationService =
            authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
        _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
    }

    public LoginViewModel() : this(null!, null!)
    {
        //
    }

    [RelayCommand]
    private async Task NavigateToRegisterAsync()
    {
        _navigationService.NavigateToAsync<RegisterViewModel>();
    }

    [RelayCommand]
    private async Task LoginAsync()
    {
        throw new NotImplementedException();
    }
}