using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SQLite;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;



namespace Maytinh
{
    class XuLyData
    {
        private SQLiteConnection database;

        private static readonly object collisionLock = new object();

        public ObservableCollection<Product> Products { get; set; }

        public XuLyData()

        {

            database = DependencyService.Get<IDatabaseConnection>().DbConnection();

            database.CreateTable<Product>();

            this.Products = new ObservableCollection<Product>(database.Table<Product>());

            if (!database.Table<Product>().Any())

            {

                AddNewProduct();

            }

        }

        public void AddNewProduct()

        {

            Product p = new Product()

            {

                Id = "Datetime",
                Loaitinhtoan = "Loại tính toán",
                Ketqua = "Kết quả"

            };

            this.Products.Add(p);

        }



        public void AddLS(string id, string loaitinhtoan, string ketqua)
        {
            lock(collisionLock)
            {
                database.Insert(new Product() { Id = id ,Loaitinhtoan = loaitinhtoan, Ketqua = ketqua });
            }    
        }
        public void DeleteAllProducts()

        {

            lock (collisionLock)

            {

                database.DropTable<Product>();

                database.CreateTable<Product>();

            }

            this.Products.Clear();

            this.Products = new ObservableCollection<Product>(database.Table<Product>());

        }


    }
}
