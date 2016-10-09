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

namespace DevAnimals.Device_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage_Mobile : Page
    {
        public MainPage_Mobile()
        {
            this.InitializeComponent();

            MyFrame.Navigate(typeof(LoginPage_mobile));

         
        }

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListBoxitem.IsSelected)
            { MyFrame.Navigate(typeof(LoginPage_mobile)); }
            else if(ShareListBoxitem.IsSelected)
            { MyFrame.Navigate(typeof(Page1_mobile)); }
            else if (InterestsListBoxItem.IsSelected)
            { MyFrame.Navigate(typeof(InterestsPage_mobile)); }
            else if (AboutListBoxItem.IsSelected)
            { MyFrame.Navigate(typeof(Page3_mobile)); }
            else if (RegisterListBoxItem.IsSelected)
            { MyFrame.Navigate(typeof(RegisterPage_mobile)); }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
