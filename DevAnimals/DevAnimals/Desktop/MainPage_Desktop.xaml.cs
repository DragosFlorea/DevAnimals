using DevAnimals.Desktop;
using DevAnimals.Desktop.Settings;
using DevAnimals.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class MainPage_Desktop : Page
    {
        Login_VM x;
        public MainPage_Desktop()
        {
            
            this.InitializeComponent();
           x  = new Login_VM();
        }
        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShareListBoxitem.IsSelected)
            {
                
            }
            else if (Login_AccountListBoxItem.IsSelected)
            {
                               
                if (!x.CheckifLogged((Login_VM)DesktopAppSettings.GetItem("LoggedUser")))
                { 
                DesktopAppSettings.AddItem("myFrameKeyforLoginNavigationtoLoginPage", MyFrame);
                MyFrame.Navigate(typeof(LoginPage_Desktop));
                }
                else
                MyFrame.Navigate(typeof(AccountPage_Desktop));
            }
            else if (NavListBoxItem.IsSelected)
            {
               
               
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!x.CheckifLogged((Login_VM)DesktopAppSettings.GetItem("LoggedUser")))
            {
                DesktopAppSettings.AddItem("myFrameKeyforLoginNavigationtoLoginPage", MyFrame);
                MyFrame.Navigate(typeof(LoginPage_Desktop));
            }
            else
                MyFrame.Navigate(typeof(NewAddPage_Desktop));
        }
    }
}
