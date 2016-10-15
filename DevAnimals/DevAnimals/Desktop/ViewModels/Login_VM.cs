using DevAnimals.Desktop.Database_Control;
using DevAnimals.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAnimals.Desktop.ViewModels
{
    internal class Login_VM
    {
        
        private LoginClass registereduser;
        public Login_VM()
        { }
        public Login_VM(LoginClass _registereduser)
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
        public bool AuthStatus
        {
            get
            {
                if (this.registereduser == null)
                {
                    return false;
                }
                return this.registereduser.authStatus;
            }
            set
            {
                if (this.registereduser != null)
                {
                    this.registereduser.authStatus = value;

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

        public bool CheckAuth(Login_VM authItem)
        {

            var x = UsersRepository.GetAllUsers();
            if (x != null)
            {
                var CheckUser = x.Any(p => p.user == authItem.User);
                var CheckPassword = x.Any(p => p.password == authItem.Password);
                if (CheckUser && CheckPassword)
                { authItem.AuthStatus = true; return true; }
            }
            else return false;
            return false;
        }
        public bool CheckifLogged(Login_VM authItem)
        {
            if (authItem != null)
                return authItem.AuthStatus;
            else
                return false;
        }
        
    }
}
