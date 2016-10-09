using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAnimals.Desktop.ComponentModel
{
    public class ObservableObjectBase:INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies that the property has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// The event that is fired when a property has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
