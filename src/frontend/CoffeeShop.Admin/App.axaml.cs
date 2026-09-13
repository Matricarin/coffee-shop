using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CoffeeShop.Admin.Services;
using CoffeeShop.Admin.ViewModels;
using CoffeeShop.Admin.ViewModels.Pages;
using CoffeeShop.Admin.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoffeeShop.Admin;

public class App : Application
{
    public IServiceProvider? Services { get; private set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            Services = ConfigureServices();

            MainWindowViewModel viewModel = Services.GetRequiredService<MainWindowViewModel>();

            desktop.MainWindow = new MainWindow { DataContext = viewModel };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private static IServiceProvider ConfigureServices()
    {
        var collection = new ServiceCollection();

        collection.AddTransient<IConfiguration>();

        collection.AddTransient<ApiClient>();

        collection.AddSingleton<IUiNavigationService, UiNavigationService>();
        collection.AddTransient<IAuthenticationService, AuthenticationService>();

        collection.AddTransient<MainWindowViewModel>();
        collection.AddTransient<LoginViewModel>();
        collection.AddTransient<RegisterViewModel>();
        collection.AddTransient<ShellViewModel>();
        collection.AddTransient<AnalyticsViewModel>();
        collection.AddTransient<ManagementViewModel>();

        return collection.BuildServiceProvider();
    }
}