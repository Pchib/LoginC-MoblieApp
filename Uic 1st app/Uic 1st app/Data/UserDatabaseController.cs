using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Uic_1st_app.Model;
using Xamarin.Forms;

namespace Uic_1st_app.Data
{
   public class UserDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().Getconnection();
            database.CreateTable<User>();
        }
        public User GetUser()
        {
            lock(locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }
        }
        public int SaveUser(User user)
        {
            lock (locker)
            {
                if(user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }
        public int DeleteUser( int Id)
        {
            return database.Delete<User>(Id);
        }
    }
}
