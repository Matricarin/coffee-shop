namespace CoffeeShop.Admin;

public sealed class ApiOptions
{
    public const string SectionName = "ApiSettings";
    public string BaseAddress { get; set; } = string.Empty;
    public int TimeoutSeconds { get; set; } = 30;
}