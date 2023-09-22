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
    public partial class GiaiHPT2An : ContentPage
    {
        private XuLyData dataAccess;
        string a = "Hệ PT 2 ẨN";
        public GiaiHPT2An()
        {
            InitializeComponent();
            this.dataAccess = new XuLyData();
        }
        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage= new ChucNang();
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a1 = double.Parse(txtNhapA1.Text);
                double b1 = double.Parse(txtNhapB1.Text);
                double c1 = double.Parse(txtNhapC1.Text);
                double a2 = double.Parse(txtNhapA2.Text);
                double b2 = double.Parse(txtNhapB2.Text);
                double c2 = double.Parse(txtNhapC2.Text);
                double D = a1 * b2 - b1 * a2;
                double Dx = c1 * b2 - b1 * c2;
                double Dy = a1 * c2 - c1 * a2;
                if (D == 0)
                {
                    if (Dx == 0)
                    {
                        if (Dy == 0)
                        {
                            lbKetQuaX.Text = "Vô số nghiệm";
                        }
                        else
                        {
                            lbKetQuaX.Text = "Vô nghiệm";
                        }
                    }
                    else
                    {
                        lbKetQuaX.Text = "Vô nghiệm";
                    }
                }
                else
                {
                    double X = Dx / D;
                    double Y = Dy / D;
                    lbKetQuaX.Text = "x = " + X.ToString();
                    lbKetQuaY.Text = "y = " + Y.ToString();
                }
            }
            catch
            {
                lbKetQuaX.Text = "Lỗi biểu thức";
            }
            string b  = lbKetQuaX.Text + " " + lbKetQuaY.Text;
            this.dataAccess.AddLS(DateTime.Now.ToString(), a, b);
        }

        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtNhapA1.Text = "";
            txtNhapA2.Text = "";
            txtNhapB1.Text = "";
            txtNhapB2.Text = "";
            txtNhapC1.Text = "";
            txtNhapC2.Text = "";
            lbKetQuaX.Text = "";
            lbKetQuaY.Text = "";
        }
    }
}