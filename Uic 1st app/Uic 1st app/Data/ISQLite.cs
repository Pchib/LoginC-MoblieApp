using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uic_1st_app.Data
{
    public interface ISQLite
    {
        SQLiteConnection Getconnection();
    }
}
