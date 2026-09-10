using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Admin.ViewModels;

public partial class RegisterViewModel : ViewModel
{
    [ObservableProperty] private string email = string.Empty;
    [ObservableProperty] private string name = string.Empty;
    [ObservableProperty] private string password = string.Empty;

    [ObservableProperty] private string passwordConfirmation = string.Empty;
}