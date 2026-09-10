using Avalonia.Controls;
using Avalonia.Controls.Templates;
using CoffeeShop.Admin.ViewModels;
using System;

namespace CoffeeShop.Admin.Views.Helpers;

public sealed class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is null)
        {
            return new TextBlock { Text = "param is null" };
        }

        var name = param.GetType().FullName!.Replace("ViewModel", "View");
        var type = Type.GetType(name);

        if (type is not null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }
        else
        {
            return new TextBlock { Text = "Не найдено " + $"{name}" };
        }
    }

    public bool Match(object? data)
    {
        return data is ViewModel;
    }
}