using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Admin.ViewModels;

public abstract class ViewModel : ObservableObject
{
    private string? _errorMessage;
    private bool _isBusy;

    public string? ErrorMessage
    {
        get => _errorMessage;
        set => SetProperty(ref _errorMessage, value);
    }

    public bool HasError => !string.IsNullOrWhiteSpace(_errorMessage);

    protected void ClearError() => ErrorMessage = null;
}