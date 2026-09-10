using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Admin.ViewModels;

public partial class ShellViewModel : ViewModel
{
    [ObservableProperty] private ViewModel currentPage;


}