using CoffeeShop.Admin.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;

namespace CoffeeShop.Admin.ViewModels;

public partial class ShellViewModel : ViewModel
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IUiNavigationService _navigationService;

    [ObservableProperty] private ViewModel currentPage;

    public ShellViewModel(IAuthenticationService authenticationService, IUiNavigationService navigationService)
    {
        _authenticationService =
            authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
        _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
    }

    public ShellViewModel() : this(null!, null!)
    {
        //
    }

    [RelayCommand]
    private async Task LogoutAsync()
    {
        throw new NotImplementedException();
    }
}