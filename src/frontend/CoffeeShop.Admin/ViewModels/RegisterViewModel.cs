using CoffeeShop.Admin.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.ViewModels;

public partial class RegisterViewModel : ViewModel
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUiNavigationService _navigationService;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
    private string email = string.Empty;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
    private string name = string.Empty;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
    private string password = string.Empty;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
    private string passwordConfirmation = string.Empty;

    public RegisterViewModel
    (
        IAuthenticationService authenticationService,
        IUiNavigationService navigationService
    )
    {
        _authenticationService =
            authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
        _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
    }

    public RegisterViewModel() : this(null!, null!)
    {
        //
    }

    [RelayCommand]
    private async Task RegisterAsync()
    {
        throw new NotImplementedException();
    }

    [RelayCommand]
    private async Task NavigateToLoginAsync()
    {
        throw new NotImplementedException();
    }
}