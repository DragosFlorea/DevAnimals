using DevAnimals.Desktop.Settings;
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
        public MainPage_Desktop()
        {
            this.InitializeComponent();
        }
        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShareListBoxitem.IsSelected)
            {
                MyFrame.Navigate(typeof(RegisterAccount_Desktop));
                DesktopAppSettings.AddItem("myFrameKeyforRegisterNavigationtoLoginPage", MyFrame);
            }
            else if (FavoritesListBoxItem.IsSelected)
            {
                MyFrame.Navigate(typeof(LoginPage_Desktop));
                DesktopAppSettings.AddItem("myFrameKeyforLoginNavigationtoAcountPage", MyFrame);
            }
            else if (NavListBoxItem.IsSelected)
            {
                MyFrame.Navigate(typeof(Page3_Desktop));
                DesktopAppSettings.AddItem("myFrameKey", MyFrame);
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
