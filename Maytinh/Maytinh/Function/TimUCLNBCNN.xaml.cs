using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maytinh.Function
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimUCLNBCNN : ContentPage
    {
        private XuLyData dataAccess;
        string o = "UCLN và BCNN";
        public TimUCLNBCNN()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lbKetQua.Text = "";
        }

        private void BtnBCNN_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double res = (a * b) / gcd(a, b);
                lbKetQua.Text = "BCNN: " + res.ToString();
            }
            catch
            {
                lbKetQua.Text = "Lỗi biểu thức";
            }
            string p = lbKetQua.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), o, p);
        }
        private void BtnUCLN_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double res = gcd(a, b);
                lbKetQua.Text = "UCLN: " + res.ToString();

            }
            catch
            {
                lbKetQua.Text = "Lỗi biểu thức";
            }
            string p = lbKetQua.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), o, p);
        }
        double gcd(double a, double b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}