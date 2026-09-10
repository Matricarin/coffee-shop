using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CoffeeShop.Admin.Services;
using CoffeeShop.Admin.ViewModels;
using CoffeeShop.Admin.ViewModels.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoffeeShop.Admin;

public partial class App : Application
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

            var viewModel = Services.GetRequiredService<MainWindowViewModel>();

            desktop.MainWindow = new Views.MainWindow()
            {
                DataContext = viewModel
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private static IServiceProvider ConfigureServices()
    {
        var collection = new ServiceCollection();

        collection.AddSingleton<IUiNavigationService, UiNavigationService>();
        collection.AddTransient<MainWindowViewModel>();
        collection.AddTransient<LoginViewModel>();
        collection.AddTransient<RegisterViewModel>();
        collection.AddTransient<ShellViewModel>();
        collection.AddTransient<AnalyticsViewModel>();
        collection.AddTransient<ManagementViewModel>();

        return collection.BuildServiceProvider();
    }
}