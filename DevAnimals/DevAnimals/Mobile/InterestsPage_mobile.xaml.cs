using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class InterestsPage_mobile : Page
    {
     //   public ObservableCollection<Category> ListOfMyInterests;
    //    public ObservableCollection<Category> ListOfAllInterests;
        public InterestsPage_mobile()
        {
            this.InitializeComponent();
         //   Interests_ViewModel local = new Interests_ViewModel();
     //       ListOfMyInterests = local.getMyInterestsList();
        //    ListOfAllInterests = local.getAllInterestsList();
       //     InterestsListBox.ItemsSource = ListOfAllInterests;
        }

        private void InterestsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void SelectInterestListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (MyInterestsListBoxItem.IsSelected)
            //{ InterestsListBox.ItemsSource = ListOfMyInterests; }
            //else if (AllInterestsListBoxItem.IsSelected)
            //{ InterestsListBox.ItemsSource = ListOfAllInterests; }
        }
    }
}
