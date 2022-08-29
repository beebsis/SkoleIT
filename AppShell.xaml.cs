using SkoleIT.Models;
using SkoleIT.ViewModels;
using SkoleIT.Views.Dashboard;

namespace SkoleIT;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        this.BindingContext = new AppShellViewModel();

         
    }
}
