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
   public class RegisterClass: ObservableObjectBase
    {

        public int IdUser { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public int telephoneNumber { get; set; }



    }

    

}
