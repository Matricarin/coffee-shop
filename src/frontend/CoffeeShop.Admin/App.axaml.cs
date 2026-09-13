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
using System.IO;

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

        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .Build();

        collection.AddSingleton(configuration);

        collection.AddHttpClient<AuthenticationService>(client =>
        {
            var options = configuration.GetSection(ApiOptions.SectionName)
                .Get<ApiOptions>();

            if (!string.IsNullOrWhiteSpace(options.BaseAddress))
            {
                client.BaseAddress = new Uri(options.BaseAddress);
            }

            client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
        });


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