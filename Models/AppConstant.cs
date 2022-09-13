using SkoleIT.Controls;
using SkoleIT.Views.Dashboard;
using SkoleIT.Views.StudentProfilePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleIT.Models
{
    public class AppConstant
    {

        public async static Task AddFlyoutMenusDetails()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl(); 

            var studentDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(StudentDashboardPage)).FirstOrDefault();
            if (studentDashboardInfo != null) AppShell.Current.Items.Remove(studentDashboardInfo);

            var teacherDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(TeacherDashboardPage)).FirstOrDefault();
            if (teacherDashboardInfo != null) AppShell.Current.Items.Remove(teacherDashboardInfo);

            var adminDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(AdminDashboardPage)).FirstOrDefault();
            if (adminDashboardInfo != null) AppShell.Current.Items.Remove(adminDashboardInfo);


            if (App.UserDetails.RoleID == (int)RoleDetails.Student)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(StudentDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                            {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Student Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(StudentDashboardPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Student Card"
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Student Profile",
                                    ContentTemplate = new DataTemplate(typeof(Views.Dashboard.StudentProfilePage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Grades",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Messages",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Schedule",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Student Your Class",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Cafeteria",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Teachers",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Maps",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Printers",

                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "File Archive",

                                }
                            }
                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(StudentDashboardPage)}");
                }

            }

            if (App.UserDetails.RoleID == (int)RoleDetails.Teacher)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(TeacherDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Teacher Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(TeacherDashboardPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Teacher Profile",
                                    ContentTemplate = new DataTemplate(typeof(TeacherDashboardPage)),
                                },
                   }
                };

                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(TeacherDashboardPage)}");
                }
            }

            if (App.UserDetails.RoleID == (int)RoleDetails.Admin)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(AdminDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                                new ShellContent
                                {
                                    Icon = Icons.Dashboard,
                                    Title = "Admin Dashboard",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),
                                },
                                new ShellContent
                                {
                                    Icon = Icons.AboutUs,
                                    Title = "Admin Profile",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),
                                },
                   }
                };

                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(AdminDashboardPage)}");
                }
            }
        }
    }
}
