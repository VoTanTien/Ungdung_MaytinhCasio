using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Maytinh
{
    public class Database: IDatabaseConnection
    {
        static public SQLiteConnection DbConnection()

        {

            var dbName = "ProductsDB.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            return new SQLiteConnection(path);
        }

        SQLiteConnection IDatabaseConnection.DbConnection()
        {
            throw new NotImplementedException();
        }
    }
   
   public interface IDatabaseConnection

    {

        SQLite.SQLiteConnection DbConnection();

    }

}


