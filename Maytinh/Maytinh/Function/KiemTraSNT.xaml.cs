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
    public partial class KiemTraSNT : ContentPage
    {
        public KiemTraSNT()
        {
            InitializeComponent();
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            lbKetQua.Text = "";
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                if (a == 0 || a == 1)
                {
                    lbKetQua.Text = a.ToString() + " không phải số nguyên tố";
                }
                else
                {
                    for (int i = 2; i <= a / 2; i++)
                    {
                        if (a % i == 0)
                        {
                            lbKetQua.Text = a.ToString() + " không phải số nguyên tố";
                            return;
                        }

                    }
                    lbKetQua.Text = a.ToString() + " là số nguyên tố";
                }
            }
            catch
            {
                lbKetQua.Text = "Lỗi biểu thức";
            }
        }

        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}