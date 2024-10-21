using Dadode.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Dadode.Views;

public sealed partial class ProjectPage : Page
{
    public ProjectViewModel ViewModel
    {
        get;
    }

    public ProjectPage()
    {
        ViewModel = App.GetService<ProjectViewModel>();
        InitializeComponent();
    }
}
