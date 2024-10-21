using Dadode.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Dadode.Views;

public sealed partial class ConnectionPage : Page
{
    public ConnectionViewModel ViewModel
    {
        get;
    }

    public ConnectionPage()
    {
        ViewModel = App.GetService<ConnectionViewModel>();
        InitializeComponent();
    }
}
