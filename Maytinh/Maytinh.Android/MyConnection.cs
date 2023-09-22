using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using Maytinh.Droid;
[assembly: Xamarin.Forms.Dependency(typeof(MyConnection))]
namespace Maytinh.Droid
{
    class MyConnection : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()

        {

            var dbName = "ProductsDB.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            return new SQLiteConnection(path);
        }
    }
}