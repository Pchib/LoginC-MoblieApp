using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Uic_1st_app.Model;
using Xamarin.Forms;

namespace Uic_1st_app.Data
{
   public class TokenDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().Getconnection();
            database.CreateTable<Token>();
        }
        public Token GetUser()
        {
            lock (locker)
            {
                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Token>().First();
                }
            }
        }
        public int SaveUser(Token user)
        {
            lock (locker)
            {
                if (user.Id != 0)
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
        public int DeleteUser(int Id)
        {
            return database.Delete<Token>(Id);
        }
    }
}

