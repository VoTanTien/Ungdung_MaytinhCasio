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
    public partial class GiaiPTBac2 : ContentPage
    {
        private XuLyData dataAccess;
        string a = "PT Bậc 2";
        public GiaiPTBac2()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lbKetQua1.Text = "";
            lbKetQua2.Text = "";
        }

        public void giaiPTB2(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) lbKetQua1.Text = "Vô số nghiệm";
                    else lbKetQua1.Text = "Vô nghiệm";
                }
                else lbKetQua1.Text = "x = " + (-c / b).ToString();
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0) lbKetQua1.Text = "Vô nghiệm";
                else if (delta == 0) lbKetQua1.Text = "x1 = x2 = " + (-b / (2 * a)).ToString();
                else
                {
                    lbKetQua1.Text = "x1 = " + ((-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                    lbKetQua2.Text = "x2 = " + ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                }
            }
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                giaiPTB2(a, b, c);
            }
            catch
            {
                lbKetQua1.Text = "Lỗi biểu thức";
            }
            string p = lbKetQua1.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), a, p);
        }

        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage= new ChucNang();
        }
    }
}