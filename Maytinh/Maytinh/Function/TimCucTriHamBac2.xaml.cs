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
    public partial class TimCucTriHamBac2 : ContentPage
    {
        private XuLyData dataAccess;
        string o = "Cực trị hàm bậc 2";
        public TimCucTriHamBac2()
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
        }

        public void timCucTriHamBac2(double a, double b, double c)
        {
            if (a == 0)
            {
                lbKetQua1.Text = "Khong co cuc tri";
            }
            else
            {
                double cucTri = -b / 2 * a;
                double y = a * Math.Pow(cucTri, 2) + b * cucTri + c;
                if (a > 0)
                {
                    lbKetQua1.Text = "Ham so dat cuc dai tai (" + cucTri.ToString() + ", " + y.ToString() + ")";
                }
                if (a < 0)
                {
                    lbKetQua1.Text = "Ham so dat cuc tieu tai (" + cucTri.ToString() + ", " + y.ToString() + ")";
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
                timCucTriHamBac2(a, b, c);
            }
            catch
            {
                lbKetQua1.Text = "Lỗi biểu thức";
            }
            string p = lbKetQua1.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), o, p);
        }

        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}
