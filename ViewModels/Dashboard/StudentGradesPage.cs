using SkoleIT.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleIT.ViewModels.Dashboard
{
    public partial class StudentGradesPage : BaseViewModel
    {
        public StudentGradesPage()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl(); 
        }
    }
}
