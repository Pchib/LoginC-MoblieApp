using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Uic_1st_app.Data;
using Uic_1st_app.iOS.Data;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency (typeof(SQLite_IOS))]
namespace Uic_1st_app.iOS.Data
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var filename = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }

        public SQLite.SQLiteConnection Getconnection()
        {
            throw new NotImplementedException();
        }
    }
}