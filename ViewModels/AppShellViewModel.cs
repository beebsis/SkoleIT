
//using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Input;
using SkoleIT.Views.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkoleIT.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {

       /* public ICommand SignOut { get; set; }

        public AppShellViewModel()
        {
            SignOut = new Command(SignOutnow);
        }*/

        [ICommand]
        public async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails)); 
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
