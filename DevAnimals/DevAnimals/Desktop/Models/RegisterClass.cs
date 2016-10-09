using DevAnimals.Desktop.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DevAnimals.Desktop.Models
{
   internal class RegisterClass: ObservableObjectBase
    {
        
        public int IdUser { get; set; }
        public string User { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }
     
    }

}
