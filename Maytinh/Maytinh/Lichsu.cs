using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SQLite;


namespace Maytinh
{
    [Table("Lịch sử")]

    class Product

    {

        private string _id;
        
        [PrimaryKey]
        [NotNull]
        public string Id

        {

            get

            {

                return _id;

            }

            set

            {

                this._id = value;

            }

        }
        private string _Loaitinhtoan;

        

        public string Loaitinhtoan

        {

            get

            {

                return _Loaitinhtoan;

            }

            set

            {

                this._Loaitinhtoan = value;

            }

        }


        private string _Ketqua;

        

        public string Ketqua

        {

            get

            {

                return _Ketqua;

            }

            set

            {

                this._Ketqua = value;

            }

        }
    }
}
