namespace CoffeeShop.Admin.ViewModels;

public abstract class ViewModel
{
    private bool _isBusy;

    private string? _errorMessage;

    public bool HasError => !string.IsNullOrWhiteSpace(_errorMessage);

    protected void ClearError() => ErrorMessage = null;
}