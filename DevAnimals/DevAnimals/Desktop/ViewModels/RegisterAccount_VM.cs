using DevAnimals.Desktop.ComponentModel;
using DevAnimals.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAnimals.Desktop.ViewModels
{
    internal class RegisterAccount_VM: ObservableObjectBase
    {

        private RegisterClass registereduser;

        
        public RegisterClass Registereduser
        {
            get { return registereduser; }
            set
            {
                this.SetProperty(ref this.registereduser, value);
                this.NotifyPropertyChanged(string.Empty);
            }
        }

        public RegisterAccount_VM(RegisterClass _registereduser)
        {
            this.registereduser = _registereduser;
        }

        public string User
        {
            get
            {
                if (this.registereduser == null)
                {
                    return string.Empty;
                }
                return this.registereduser.user;
            }
            set
            {
                if (this.registereduser != null)
                {
                    this.registereduser.user = value;
                  
                }
            }
        }
        public string Password
        {
            get
            {
                if (this.registereduser == null)
                {
                    return string.Empty;
                }
                return this.registereduser.password;
            }
            set
            {
                if (this.registereduser != null)
                {
                    this.registereduser.password = value;
                    
                }
            }
        }
        public string IDUser
        {
            get
            {
                if (this.registereduser == null)
                {
                    return string.Empty;
                }
                return new Guid().ToString();
            }
            
        }
        public int TelephoneNumber
        {
            get
            {
                if (this.registereduser == null)
                {
                    return 0;
                }
                return this.registereduser.telephoneNumber;
            }
            set
            {
                if (this.registereduser != null)
                {
                    this.registereduser.telephoneNumber = value;

                }
            }
        }
        public string Email
        {
            get
            {
                if (this.registereduser == null)
                {
                    return string.Empty;
                }
                return this.registereduser.email;
            }
            set
            {
                if (this.registereduser != null)
                {
                    this.registereduser.email = value;

                }
            }
        }
        public string Location
        {
            get
            {
                if (this.registereduser == null)
                {
                    return string.Empty;
                }
                return this.registereduser.location;
            }
            set
            {
                if (this.registereduser != null)
                {
                    this.registereduser.location = value;

                }
            }
        }
    }
}
