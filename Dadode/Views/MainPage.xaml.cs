﻿using Dadode.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Dadode.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
