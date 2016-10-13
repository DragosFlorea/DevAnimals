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
                if (CheckUser && CheckPassword) return true;
            }
            else return false;
            return false;
        }
    }
}
