using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Admin.ViewModels;

public partial class MainWindowViewModel : ViewModel
{
    [ObservableProperty] private ViewModel currentPage;
}