using DevAnimals.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAnimals.Desktop.Database_Control
{
   internal static class UsersRepository
    {
        internal static List<RegisterClass>GetAllUsers()
            {
            using (var db = new DevAnimalsContext())
                {
                return db.Accounts.ToList();
                }
            }
        internal static void SaveUser(RegisterClass model)
        {
            using (var db = new DevAnimalsContext())
            {
                if (model.IdUser > 0)
                {
                    db.Attach(model);
                    db.Update(model);
                }
                else
                {
                    db.Add(model);
                }
                db.SaveChanges();
            }
        }
        
    }
}
