using DevAnimals.Desktop;
using DevAnimals.Desktop.Database_Control;
using DevAnimals.Desktop.Models;
using DevAnimals.Desktop.Settings;
using DevAnimals.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DevAnimals.Device_Desktop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage_Desktop : Page
    {
        private Login_VM LoginUser;
        Frame MyFrame;
        public LoginPage_Desktop()
        {
            this.InitializeComponent();
            LoginUser = new Login_VM(new LoginClass());
            MyFrame = (Frame)DesktopAppSettings.GetItem("myFrameKeyforLoginNavigationtoLoginPage");
            DataContext = LoginUser;
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login_VM x = new Login_VM();
            
            var response=x.CheckAuth(LoginUser);

            if (response)
            {
                var dialog = new MessageDialog("Login Complete!");
                await dialog.ShowAsync();
                DesktopAppSettings.AddItem("LoggedUser", LoginUser);
                MyFrame.Navigate(typeof(AccountPage_Desktop));
                
            }
            else
            {
                var dialog = new MessageDialog("User or password incorrect!! Please try again.");
                await dialog.ShowAsync();
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(RegisterAccount_Desktop));
            DesktopAppSettings.AddItem("myFrameKeyforRegisterNavigationtoLoginPage", MyFrame);
        }
    }
}
