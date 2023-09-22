using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Maytinh.Function;
namespace Maytinh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoiDonVi : ContentPage
    {
        public DoiDonVi()
        {
            InitializeComponent();
        }
        private void BtnHome_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        private void BtnKhoangCach_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new KhoangCach();
        }
        private void BtnTrongLuong_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiTrongLuong();
        }
        private void BtnNhietDo_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiNhietDo();
        }
        private void BtnVanToc_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new DoiVanToc();
        }
    }
}