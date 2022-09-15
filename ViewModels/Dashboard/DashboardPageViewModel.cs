using SkoleIT.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleIT.ViewModels.Dashboard
{
    public partial class DashboardPageViewModel : BaseViewModel
    {
        public DashboardPageViewModel()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl(); 
        }

        public class Elev
        {
            public string FirstName { get; }
            public string SirName { get; }
            public string Picture_path { get; }
            public string Birthdate { get; }
            public string Workplace { get; }
            public string Education_end { get; }
            public string Username { get; }
        }
    }
}
