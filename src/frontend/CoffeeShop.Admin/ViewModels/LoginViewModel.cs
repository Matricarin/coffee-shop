using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Admin.ViewModels;

public partial class LoginViewModel : ViewModel
{
    [ObservableProperty] private string email = string.Empty;

    [ObservableProperty] private string password = string.Empty;
}