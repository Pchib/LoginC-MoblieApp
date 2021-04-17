using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Uic_1st_app.Data;
using Uic_1st_app.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Andriod))]

namespace Uic_1st_app.Droid.Data
{
    class SQLite_Andriod : ISQLite
    {
       
            public SQLite_Andriod() { }
            public SQLite.SQLiteConnection GetConnection()
            {
                var sqliteFileName = "TestDB.db3";
                string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var path = Path.Combine(documentsPath, sqliteFileName);
                var conn = new SQLite.SQLiteConnection(path);


                return conn;
            }

        public SQLiteConnection Getconnection()
        {
            throw new NotImplementedException();
        }
    }
    }