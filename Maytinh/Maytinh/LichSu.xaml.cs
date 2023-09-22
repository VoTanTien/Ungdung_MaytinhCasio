using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maytinh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LichSu : ContentPage
    {
        private XuLyData dataAccess;
        public LichSu()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        protected override void OnAppearing()

        {

            base.OnAppearing();

            this.BindingContext = this.dataAccess;

        }
        private void BtnHome_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        private void BtnXoa_clicked(object sender, EventArgs e)
        {
            this.dataAccess.DeleteAllProducts();

            this.dataAccess = new XuLyData();

            this.BindingContext = this.dataAccess;
        }

    }
}