using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
//using CommunityToolkit.Mvvm.Input;
//using CommunityToolkit.Mvvm.ComponentModel;


using Newtonsoft.Json;
using SkoleIT.Controls;
using SkoleIT.Models;
using SkoleIT.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SkoleIT.ViewModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email; 

        [ObservableProperty]
        private string _password;

        #region Commands
       /* public ICommand Login { get; set; }

        public LoginPageViewModel()
        {
            Login = new Command(Loginnow);
        }*/

        [ICommand]
        async void Login()
        {
            if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            {
                var userDetails = new UserBasicInfo
                {
                    Email = Email,
                    FullName = "Test User Name"
                };

                // Student Role, Teacher Role, Admin Role,
                if (Email.ToLower().Contains("student"))
                {
                    userDetails.RoleID = (int)RoleDetails.Student;
                    userDetails.RoleText = "Student Role";
                }
                else if (Email.ToLower().Contains("teacher"))
                {
                    userDetails.RoleID = (int)RoleDetails.Teacher;
                    userDetails.RoleText = "Teacher Role";
                }
                else
                {
                    userDetails.RoleID = (int)RoleDetails.Admin;
                    userDetails.RoleText = "Admin Role";
                }


                // calling api 


                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }

                string userDetailStr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailStr);
                App.UserDetails = userDetails;
                await AppConstant.AddFlyoutMenusDetails();
            }


        }
        #endregion
    }
}
